using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSelectScript : MonoBehaviour
{
    private List<Button> buttons = new List<Button>();
	
	void Awake()
	{
		GetButtonsAndListeners();
	}
	
	void GetButtonsAndListeners()
	{
		GameObject[] btns = GameObject.FindGameObjectsWithTag("MenuBall");
		for (int i = 0; i < btns.Length; i++)
		{
			buttons.Add(btns[i].GetComponent<Button>());
			buttons[i].onClick.AddListener(() => SelectBall());
		}
	}
	
	public void SelectBall()
	{
		int index = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
		Debug.Log("The Selected index is " + index);
		// inform game manager which index is select
	}		
	
}
