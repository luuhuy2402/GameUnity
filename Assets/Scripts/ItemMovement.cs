using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
	public float moveSpeed = 2f; // Tốc độ di chuyển sang trái
	public float lifetime = 10f; // Thời gian tồn tại của vật phẩm trước khi biến mất

	void Start()
	{
		// Tự hủy vật phẩm sau một khoảng thời gian nhất định
		Destroy(gameObject, lifetime);
	}

	void Update()
	{
		// Di chuyển vật phẩm từ phải sang trái
		transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
	}
}
