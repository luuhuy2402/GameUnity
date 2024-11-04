using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotingItem : MonoBehaviour
{
    Animator Animator;
    Object Ball;
	// Start is called before the first frame update
	void Start()
    {
		Ball = Resources.Load("Shooting");
        Animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Animator.SetBool("isShooting", true);
            GameObject fireball=(GameObject)Instantiate(Ball);
            fireball.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, -1);
            Invoke("TrigerAnim", 2f);
        }
       
    }
    void TrigerAnim()
    {
        Animator.SetBool("isShooting", false);
    }    
}
