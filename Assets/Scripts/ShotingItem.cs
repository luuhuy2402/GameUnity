using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotingItem : MonoBehaviour
{
    Animator Animator;
    Object Ball;
    public int n=5;
	public Text myText;
	// Start is called before the first frame update
	void Start()
    {
		Ball = Resources.Load("Shotting");
        Animator = GetComponent<Animator>();
		UpdateBulletCountUI();

	}

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1)& n>0)
        {
            Shoot();
        }
		if (Input.GetKeyDown(KeyCode.H))
		{
			n += 2;
            UpdateBulletCountUI();
		}

	}
    void Shoot()
    {
		Animator.SetBool("isShoot", true);
		GameObject fireball = (GameObject)Instantiate(Ball);
		fireball.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, -1);
        n--;
        UpdateBulletCountUI();
		Invoke("TrigerAnim", 2f);

	}
    void TrigerAnim()
    {
        Animator.SetBool("isShoot", false);
    }
	void UpdateBulletCountUI()
	{
		if (myText != null)
		{
			myText.text = n + "X "  ;
		}
	}
}
