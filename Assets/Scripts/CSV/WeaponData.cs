﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class WeaponData : ScriptableObject {
	[System.Serializable]
	public class Attribute
	{
		// ItemNo, Type, isMelee , feature,itemHP itemDamage  itemCriticalChance itemCriticalHit 
		// itemAttackSpeed  Slot1  Velue1 Slot2  Velue2
		public string itemNo;
		public string type; // TODO : change item.itemType 
		public string isMelee;
		public string feature;
		public int itemHP;
		public int itemDamage;
		public float itemCriticalChance;
		public float itemCriticalHit;
		public float itemAttackSpeed;
		public string slot1;
		public int value1;
		public string slot2;
		public int value2;
	}

	public List<Attribute> list = new List<Attribute>();
}