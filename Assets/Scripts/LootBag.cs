using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBag : MonoBehaviour
{
	public GameObject droppedItemPrefab;
	public List<Loot> lootList = new List<Loot>();
	//public Transform backgroundQuad;

	Loot GetDroppedItem()
	{
		//int randomNumber = Random.Range(1, 101);
		//List<Loot> possibleItems = new List<Loot>();
		//foreach (Loot item in lootList)
		//{
		//	if (randomNumber <= item.dropChance)
		//	{
		//		possibleItems.Add(item);
		//	}
		//}
		//if (possibleItems.Count > 0)
		//{
		//	Loot droppedItem = possibleItems[Random.Range(0, possibleItems.Count)];
		//	return droppedItem;
		//}
		//Debug.Log("No log dropped");
		//return null;

		// Chọn một vật phẩm ngẫu nhiên từ danh sách loot
		Loot droppedItem = lootList[Random.Range(0, lootList.Count)];
		return droppedItem;
	}
	//public void InstantiateLoot()
	//{
	//	Loot droppedItem = GetDroppedItem();
	//	if (droppedItem != null)
	//	{
	//		GameObject lootGameObject = Instantiate(droppedItemPrefab, sqawnPosition, Quaternion.identity);
	//		lootGameObject.GetComponent<SpriteRenderer>().sprite = droppedItem.lootSprite;
	//	}


	//}

	public void InstantiateLoot(Vector3 spawnPosition)
	{
	

		Loot droppedItem = GetDroppedItem();
		if (droppedItem != null && droppedItem.lootPrefab != null)
		{
			GameObject lootGameObject= Instantiate(droppedItem.lootPrefab, spawnPosition, Quaternion.identity);
			Debug.Log("dO NE");
			//if (backgroundQuad != null)
			//{
			//	lootGameObject.transform.SetParent(backgroundQuad);
			//}
		}
	}

}