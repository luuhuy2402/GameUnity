using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Loot : ScriptableObject
{
	//public Sprite lootSprite;
	public GameObject lootPrefab; // S? d?ng prefab thay vì sprite

	public string lootName;
	public int dropChance;
	public Loot(string lootName, int dropChance)
	{
		this.lootName = lootName;
		this.dropChance = dropChance;
	}
}
