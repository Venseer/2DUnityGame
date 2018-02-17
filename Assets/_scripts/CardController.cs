using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardController : MonoBehaviour, IPointerClickHandler
{
	private GameObject go_PlayerHand;
	public Text[] ar_CardTexts;
	public Text Card_Title;
	public Text Card_Power;
	public Text Card_Speed;
	public Text Card_Range;
	public Text Card_Abilities;
	
	void Awake()
    {
        ar_CardTexts = GetComponentsInChildren<Text>();
        SetCardAttributes();
    }

    private void SetCardAttributes()
    {
        Card_Title = FindTextFieldByName("Card_Title");
        Card_Range = FindTextFieldByName("Card_Range");
        Card_Power = FindTextFieldByName("Card_Power");
        Card_Speed = FindTextFieldByName("Card_Speed");
        Card_Abilities = FindTextFieldByName("Card_Abilities");
    }

    void Start()
	{
		go_PlayerHand = GameObject.FindGameObjectWithTag("Player_Hand");
	}

	public Text FindTextFieldByName(string Name){
		foreach(Text t in ar_CardTexts){
			if(t.name.Equals(Name)){
				return t;
			}
		}
		return null;
	}
	
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("You Clicked: " + Card_Title.text + "!!");
    }
}
