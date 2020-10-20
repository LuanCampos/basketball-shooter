using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
	[SerializeField]
	private GameObject ball;
	[SerializeField]
	private Sprite[] ballImages;
	
	private float minX = -4.7f;
	private float maxX = 8f;
	private float minY = -2.5f;
	private float maxY = 1.5f;
	
	public void CreateBall(int index)
	{
		GameObject gameBall = Instantiate(ball, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0), Quaternion.identity) as GameObject;
		gameBall.GetComponent<SpriteRenderer>().sprite = ballImages[index];
	}

}
