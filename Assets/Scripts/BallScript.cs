using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{	
	void OnCollisionEnter2D(Collision2D target)
	{
		if (target.gameObject.tag == "Holder")
		{
			if (GameManager.instance != null)
			{
				if (Random.Range(0, 2) > 1)
				{
					GameManager.instance.PlaySound(3);
				}
				else
				{
					GameManager.instance.PlaySound(4);
				}
			}
		}
		
		if (target.gameObject.tag == "Ram")
		{
			if (GameManager.instance != null)
			{
				if (Random.Range(0, 2) > 1)
				{
					GameManager.instance.PlaySound(2);
				}
				else
				{
					GameManager.instance.PlaySound(5);
				}
			}
		}
		
		if (target.gameObject.tag == "Ground")
		{
			if (GameManager.instance != null)
			{
				if (Random.Range(0, 2) > 1)
				{
					GameManager.instance.PlaySound(3);
				}
				else
				{
					GameManager.instance.PlaySound(4);
				}
			}
		}
		
		if (target.gameObject.tag == "Table")
		{
			if (GameManager.instance != null)
			{
				if (Random.Range(0, 2) > 1)
				{
					GameManager.instance.PlaySound(2);
				}
				else
				{
					GameManager.instance.PlaySound(5);
				}
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "Net")
		{
			if (GameManager.instance != null)
			{
				GameManager.instance.PlaySound(1);
			}
		}
	}

}
