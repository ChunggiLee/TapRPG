using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PlayerData : ScriptableObject
{
    [System.Serializable]
    public class Attribute
    {
        public int gold;
        public int baseHp;
        public float baseAttack;
        public float baseCriticalChance;
        public float baseCriticalHit;
        public float baseAttackSpeed;

        //items
        public int itemHP;
        public float itemAttack;
        public float itemCriticalChance;
        public float itemCriticalHit;
        public float itemAttackSpeed;
        public float itemBulletSpeed = 5f;
        public int itemBulletCol = 0;

        //monster

    }

    public List<Attribute> list = new List<Attribute>();
}