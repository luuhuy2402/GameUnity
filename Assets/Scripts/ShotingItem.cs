using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotingItem : MonoBehaviour
{
    Animator Animator;
 
    public int n=10;
	public Text myText;
	bool isShooting = false;
	[SerializeField] public GameObject shootingPrefab; 
	void Start()
    {
		
        Animator = GetComponent<Animator>();
		UpdateBulletCountUI();

	}

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
			
			isShooting=!isShooting;
			Animator.SetBool("isShooting", isShooting);
		}
		//if (Input.GetMouseButtonUp(0))
		//{
		//	n += 2;
		//	Animator.SetBool("isShooting", false);
		//	UpdateBulletCountUI();
		//}

	}
    void Shoot()
    {
		//Animator.SetBool("isShooting", true);
		GameObject fireball = (GameObject)Instantiate(shootingPrefab);
		fireball.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, -1);
        n--;
        UpdateBulletCountUI();
		Invoke("TrigerAnim", 2f);

	}
    //void TrigerAnim()
    //{
    //    Animator.SetBool("isShooting", false);
    //}


	public void UpdateBulletCountUI()
	{
		if (myText != null)
		{
			myText.text = n + "X "  ;
		}
	}
}