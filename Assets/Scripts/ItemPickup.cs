using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
	//public Sprite itemIcon; // Icon của vật phẩm để hiển thị
	//public Image uiItemDisplay; // Image trên UI để hiện vật phẩm đã thu thập

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("player")) // Kiểm tra nếu va chạm với nhân vật
		{
			// Hiển thị icon của vật phẩm trên UI
			//if (uiItemDisplay != null)
			//{
			//	uiItemDisplay.sprite = itemIcon; // Đặt sprite của UI thành icon của vật phẩm
			//	uiItemDisplay.enabled = true; // Bật hiển thị UI
			//}
			//else
			//{
			//	Debug.LogWarning("uiItemDisplay chưa được gán trong Inspector.");
			//}

			// Biến mất vật phẩm
			Destroy(gameObject);
		}
	}


	//public GameObject itemPrefab;  // Prefab của vật phẩm để hiển thị
	//public GameObject uiDisplayParent; // Đổi từ Transform thành GameObject


	//private void OnTriggerEnter2D(Collider2D collision)
	//{
	//	if (collision.CompareTag("Player")) // Kiểm tra nếu va chạm với nhân vật
	//	{
	//		// Instantiate prefab của vật phẩm lên giao diện
	//		if (uiDisplayParent != null && itemPrefab != null)
	//		{
	//			GameObject itemInstance = Instantiate(itemPrefab, uiDisplayParent.transform);

	//			itemInstance.transform.localPosition = Vector3.zero; // Đặt vị trí tại tâm của vị trí hiển thị
	//		}
	//		else
	//		{
	//			Debug.LogWarning("uiDisplayParent hoặc itemPrefab chưa được gán trong Inspector.");
	//		}

	//		// Biến mất vật phẩm trong thế giới game
	//		Destroy(gameObject);
	//	}
	//}
}
