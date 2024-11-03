using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    Rigidbody2D rb;
	
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		//Invoke("DestroySelf", .5f);
    }

	// Update is called once per frame
	private void FixedUpdate()
	{
		
        rb.velocity = new Vector2(3, 0);
	}
	public void DestroySelf()
	{
		Destroy(gameObject);
	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject); 
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		//if (collision.gameObject.CompareTag("Enemy"))
		//{
		//	DestroySelf();	
		//}
	}
	
}
