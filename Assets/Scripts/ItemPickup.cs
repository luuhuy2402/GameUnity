using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
	//public Sprite itemIcon; // Icon của vật phẩm để hiển thị
	//public Image uiItemDisplay; // Image trên UI để hiện vật phẩm đã thu thập

	//private void OnTriggerEnter2D(Collider2D collision)
	//{
	//	if (collision.CompareTag("player")) // Kiểm tra nếu va chạm với nhân vật
	//	{
	//		// Hiển thị icon của vật phẩm trên UI
	//		//if (uiItemDisplay != null)
	//		//{
	//		//	uiItemDisplay.sprite = itemIcon; // Đặt sprite của UI thành icon của vật phẩm
	//		//	uiItemDisplay.enabled = true; // Bật hiển thị UI
	//		//}
	//		//else
	//		//{
	//		//	Debug.LogWarning("uiItemDisplay chưa được gán trong Inspector.");
	//		//}

	//		// Biến mất vật phẩm
	//		Destroy(gameObject);
	//	}
	//}


	public enum ItemType { Ammo, HP, Life }
	public ItemType itemType;
	public int amount = 5; // Số lượng mặc định để tăng (có thể thay đổi trong Inspector)

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("player"))
		{
			//switch (itemType)
			//{
			//	case ItemType.Ammo:
			//		ShotingItem shootingScript = collision.GetComponent<ShotingItem>();
			//		if (shootingScript != null)
			//		{
			//			shootingScript.n += amount;
			//			shootingScript.UpdateBulletCountUI();
			//		}
			//		break;
			//	case ItemType.HP:
			//		HeathBar healthBar = collision.GetComponent<HeathBar>();
			//		if (healthBar != null && healthBar.heath < 100)
			//		{
			//			healthBar.heath = Mathf.Min(100, healthBar.heath + amount);
			//			healthBar.fillBar.fillAmount = healthBar.heath / 100f;
			//			Debug.Log("HP increased to: " + healthBar.heath);
			//		}
			//		break;
			//	case ItemType.Life:
			//		LifeCount lifeCount = collision.GetComponent<LifeCount>();
			//		if (lifeCount != null && lifeCount.livesRemaining < lifeCount.lives.Length)
			//		{
			//			lifeCount.lives[lifeCount.livesRemaining].enabled = true;
			//			lifeCount.livesRemaining++;
			//			Debug.Log("Life increased to: " + lifeCount.livesRemaining);
			//		}
			//		break;
			//}

			// Biến mất vật phẩm sau khi được thu thập
			Destroy(gameObject);
		}
	}
}
