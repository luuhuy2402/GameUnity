using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureController : MonoBehaviour
{
	public float moveBackDistance = 2.0f; // Khoảng cách lùi lại
	public float waitTime = 30.0f; // Thời gian chờ trước khi lùi lại (30 giây)

	private Vector3 initialPosition;

	private void Start()
	{
		initialPosition = transform.position;
		StartCoroutine(MoveBackAfterTime());
	}

	private IEnumerator MoveBackAfterTime()
	{
		yield return new WaitForSeconds(waitTime); // Chờ trong 30 giây

		// Lùi lại một khoảng
		Vector3 moveBack = new Vector3(-moveBackDistance, 0, 0);
		transform.position = initialPosition + moveBack;
	}
}
