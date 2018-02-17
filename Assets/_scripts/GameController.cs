using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	private GameObject go_PlayerCharacter;
	private GameObject go_PlayerHand;
	private GameObject go_ConfirmButton;
	private GameObject go_CardToConfirm;
	public TurnController turnController;

	void Awake()
	{
		turnController = new TurnController();
	}
	void Start()
    {
		FillGameObjects();
		go_ConfirmButton.SetActive(false);
		turnController.StartNewFight();
    }

    private void FillGameObjects()
    {
        go_PlayerCharacter = GameObject.FindGameObjectWithTag("Character_01");
        go_PlayerHand = GameObject.FindGameObjectWithTag("Player_Hand");
        go_ConfirmButton = GameObject.FindGameObjectWithTag("Confirmation_Button");
    }
}
