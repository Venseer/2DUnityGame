using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    private int i_CardCount;
    private CardController[] mb_Cards;

    void Start()
    {
        mb_Cards = GetComponentsInChildren<CardController>();
        i_CardCount = mb_Cards.Length;
        Debug.Log(i_CardCount);

        CardFiller();
    }

    private void CardFiller()
    {
        int count = 0;
        foreach (CardController card in mb_Cards)
        {
            Card currentCard = MockCards.Cards[count];
            card.Card_Title.text = currentCard.Name;
            if (currentCard.hasRange)
            {
                if (currentCard.hasMinMaxRange)
                {
                    card.Card_Range.text = currentCard.MinRange.ToString() + "~" + currentCard.MaxRange.ToString();
                }
				else{
                	card.Card_Range.text = currentCard.MaxRange.ToString();
				}
            }
            else
            {
                card.Card_Range.text = "X";
            }
            if (currentCard.hasPower){
                card.Card_Power.text = currentCard.Power.ToString();
			}
            else{
                card.Card_Power.text = "X";
			}
            if (currentCard.hasSpeed){
                card.Card_Speed.text = currentCard.Speed.ToString();
			}
            else{
                card.Card_Speed.text = "X";
			}
            card.Card_Abilities.text = currentCard.Abilities.ToString();
            count++;
        }
    }
}
