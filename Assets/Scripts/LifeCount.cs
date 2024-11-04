using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
	public Image[] lives;
	public int livesRemaining=3;

	public void loseLife()
	{
		if (livesRemaining > 0)
		{
			
			livesRemaining -=1;
			lives[livesRemaining].enabled = false;


			if (livesRemaining == 0)
			{
				Debug.Log("You Lose");
			}
		}
	}

	void Update()
	{
		//if (Input.GetKeyUp(KeyCode.Return))
		//{
		//	loseLife();
		//}
	}
}
