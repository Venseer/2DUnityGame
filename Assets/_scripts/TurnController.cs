using System;
using UnityEngine;
using UnityEngine.UI;

public class TurnController
{
    public enum TurnState { WAITING_CARDS, REVEAL, CHECK_SPEED, START, BEFORE_ACTIVATING, ON_HIT, ON_DAMAGE, AFTER_ACTIVATING, TURN_END };
    public TurnState CURRENT_STATE;
    public event EventHandler OnStateChange;
    public event EventHandler OnActionReady;
    public int Round;
    public int YourHealth;
    public int OpponentHealth;
    public Text t_HealthDisplay;
    public Text t_TurnDisplay;
    private const string Health_Display_Text = "Your Health: [1] \nOpponent's Health: [2]";
    private const string Turn_Display_Text = "Round - [1]";

    public TurnController()
    {
        t_HealthDisplay = GameObject.FindGameObjectWithTag("Health_Display").GetComponent<Text>();
        t_TurnDisplay = GameObject.FindGameObjectWithTag("Round_Display").GetComponent<Text>();
    }

    public void StartNewFight()
    {
        this.CURRENT_STATE = TurnState.WAITING_CARDS;
        YourHealth = 20;
        OpponentHealth = 20;
        Round = 1;
        UpdateInfoScreen();
    }

    public void UpdateInfoScreen()
    {
        t_HealthDisplay.text = Health_Display_Text.Replace("[1]", YourHealth.ToString()).Replace("[2]", OpponentHealth.ToString());
        t_TurnDisplay.text = Turn_Display_Text.Replace("[1]", Round.ToString());
    }

    /*Get ready for some bullshit */
    public void NextRoundState()
    {
        if (CURRENT_STATE == TurnState.WAITING_CARDS)
        {
            CURRENT_STATE = TurnState.REVEAL;
        }
        if (CURRENT_STATE == TurnState.REVEAL)
        {
            CURRENT_STATE = TurnState.CHECK_SPEED;
        }
        if (CURRENT_STATE == TurnState.CHECK_SPEED)
        {
            CURRENT_STATE = TurnState.START;
        }
        if (CURRENT_STATE == TurnState.START)
        {
            CURRENT_STATE = TurnState.BEFORE_ACTIVATING;
        }
        if (CURRENT_STATE == TurnState.BEFORE_ACTIVATING)
        {
            CURRENT_STATE = TurnState.ON_HIT;
        }
        if (CURRENT_STATE == TurnState.ON_HIT)
        {
            CURRENT_STATE = TurnState.ON_DAMAGE;
        }
        if (CURRENT_STATE == TurnState.ON_DAMAGE)
        {
            CURRENT_STATE = TurnState.AFTER_ACTIVATING;
        }
        if (CURRENT_STATE == TurnState.AFTER_ACTIVATING)
        {
            CURRENT_STATE = TurnState.TURN_END;
        }
        if (CURRENT_STATE == TurnState.TURN_END)
        {
            CURRENT_STATE = TurnState.WAITING_CARDS;
            Round++;
        }
    }

}