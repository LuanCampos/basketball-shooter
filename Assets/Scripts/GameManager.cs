using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;	
	private BallCreator ballCreator;
	private int index = 0;
	private AudioSource audio;
	private float volume = 1.0f;
	
	[SerializeField]
	private AudioClip rimHit1, rimHit2, bounce1, bounce2, netSound;
	
	void Awake()
	{
		MakeSingleton();
		audio = GetComponent<AudioSource>();
		ballCreator = GetComponent<BallCreator>();
	}
	
	void MakeSingleton()
	{
		if (instance != null)
		{
			Destroy (gameObject);
		}
		
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}
	
	void OnLevelWasLoaded()
	{
		if (Application.loadedLevelName == "Gameplay")
		{
			CreateBall();
		}
	}
	
	public void CreateBall()
	{
		ballCreator.CreateBall(index);
	}
	
	public void SetBallIndex(int index)
	{
		this.index = index;
	}
	
	public void PlaySound(int id)
	{
		switch (id)
		{
			case 1:
			audio.PlayOneShot(netSound, volume);
				break;
			
			case 2:
				if (Random.Range(0, 2) > 1)
				{
					audio.PlayOneShot(rimHit1, volume);
				}
				else
				{
					audio.PlayOneShot(rimHit2, volume);
				}
				break;
				
			case 3:
				if (Random.Range(0, 2) > 1)
				{
					audio.PlayOneShot(bounce1, volume);
				}
				else
				{
					audio.PlayOneShot(bounce2, volume);
				}
				break;
				
			case 4:
				if (Random.Range(0, 2) > 1)
				{
					audio.PlayOneShot(bounce1, volume / 2);
				}
				else
				{
					audio.PlayOneShot(bounce2, volume / 2);
				}
				break;
				
			case 5:
				if (Random.Range(0, 2) > 1)
				{
					audio.PlayOneShot(rimHit1, volume / 2);
				}
				else
				{
					audio.PlayOneShot(rimHit2, volume / 2);
				}
				break;
		}
	}


}
