using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
	void Start()
	{
		
		
	}

	void OnMouseDown()
	{
		GetComponent<LootBag>().InstantiateLoot(transform.position);
		Debug.Log("Click");
		Destroy(gameObject);
	}

}