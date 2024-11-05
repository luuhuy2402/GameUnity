using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
	public Sprite itemIcon; // Icon của vật phẩm để hiển thị
	public Image uiItemDisplay; // Image trên UI để hiện vật phẩm đã thu thập

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("player")) // Kiểm tra nếu va chạm với nhân vật
		{
			// Hiển thị icon của vật phẩm trên UI
			if (uiItemDisplay != null)
			{
				uiItemDisplay.sprite = itemIcon; // Đặt sprite của UI thành icon của vật phẩm
				uiItemDisplay.enabled = true; // Bật hiển thị UI
			}

			// Biến mất vật phẩm
			Destroy(gameObject);
		}
	}



}
