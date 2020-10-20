using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
	private Animator mainAnim;
	private Animator ballAnim;
	
	void Awake()
	{
		mainAnim = GameObject.Find("Main Holder").GetComponent<Animator>();
		ballAnim = GameObject.Find("Balls Holder").GetComponent<Animator>();
	}
	
	public void PlayGame()
	{
		Application.LoadLevel("Gameplay");
	}
	
	public void SelectBall()
	{
		mainAnim.Play("FadeOut");
		ballAnim.Play("FadeIn");
	}
	
	public void BackToMenu()
	{
		ballAnim.Play("FadeOut");
		mainAnim.Play("FadeIn");
	}

}
