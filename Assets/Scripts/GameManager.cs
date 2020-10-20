using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	private BallCreator ballCreator;
	private int index = 0;
	
	void Awake()
	{
		MakeSingleton();
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
			CreateBall(index);
		}
	}
	
	public void CreateBall(int index)
	{
		ballCreator.CreateBall(index);
	}
	
	public void SetBallIndex(int index)
	{
		this.index = index;
	}


}
