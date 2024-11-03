using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathBar : MonoBehaviour
{
    public Image fillBar;
    public float heath=100;
	public LifeCount lifeCount;
	// Start is called before the first frame update
	public void LoseHeath(int value)
    {
        if (heath <= 0)
        {
			Debug.Log("Heath is already 0 or less.");
			return;
        }
        heath -= value;
        fillBar.fillAmount = heath/100;
		Debug.Log("Current Health: " + heath);
		if ( heath <=0 )
        {
            Debug.Log("You Died");
			lifeCount.loseLife();
			if (lifeCount.livesRemaining > 0)
			{
				heath = 100;
				fillBar.fillAmount = 1;
			}
		}
        

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyUp(KeyCode.Return))
		{
			LoseHeath(10);
            Debug.Log("Miss");
		}
	}
}
