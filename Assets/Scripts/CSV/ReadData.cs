﻿using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class ReadData: AssetPostprocessor
{
    static readonly string playerExportPath = "Assets/Resources/Data/PlayerData.asset";
    static readonly string monsterExportPath = "Assets/Resources/Data/MonsterData.asset";
    static readonly string stageExportPath = "Assets/Resources/Data/StageData.asset";
	static readonly string weaponExportPath = "Assets/Resources/Data/WeaponData.asset";
	static readonly string equipmentExportPath = "Assets/Resources/Data/EquipmentData.asset";
    static readonly string resultResourcePath = "Assets/Resources/Data/";


    [MenuItem("DataManagemant/DataExport #&g")]
    static void ExcelImport()
    {
        Debug.Log("Excel data covert start.");

        //스크립터블 오브젝트 생성 폴더
        if (!Directory.Exists(resultResourcePath))
        {
            Directory.CreateDirectory(resultResourcePath);
        }

        MakePlayerData();
        MakeMonsterData();
        MakeStageData();
		MakeWeaponData ();
		MakeEquipmentData ();

        Debug.Log("Excel data covert complete.");
    }

    /// <summary>
    /// 주인공 정보를 ScriptableObject만듬
    /// </summary>
    static void MakePlayerData()
    {
        //SciprtableObject를 생성
        PlayerData data = ScriptableObject.CreateInstance<PlayerData>();
        //ScriptableObject를 파일로 만듬
        AssetDatabase.CreateAsset((ScriptableObject)data, playerExportPath);
        //수정 불가능하게 설정(에디터에서 수정 하게 하려면 주석처리)
        data.hideFlags = HideFlags.NotEditable;

        //자료를 삭제(초기화)
        data.list.Clear();

        //위에서 생성된 SciprtableObject의 파일을 찾음
        ScriptableObject obj =
            AssetDatabase.LoadAssetAtPath(playerExportPath, typeof(ScriptableObject)) as ScriptableObject;
        //디스크에 쓰기
        EditorUtility.SetDirty(obj);
    }


    /// <summary>
    /// Monster 정보를 ScriptableObject만듬
    /// </summary>
    static void MakeMonsterData()
    {
        //SciprtableObject를 생성
        MonsterData data = ScriptableObject.CreateInstance<MonsterData>();
        //ScriptableObject를 파일로 만듬
        AssetDatabase.CreateAsset((ScriptableObject)data, monsterExportPath);
        //수정 불가능하게 설정(에디터에서 수정 하게 하려면 주석처리)
        data.hideFlags = HideFlags.NotEditable;

        //자료를 삭제(초기화)
        data.list.Clear();




        //CSVRead
        List<Dictionary<string,object>> csvData = CSVReader.Read("CSV/Monster");

        for (int i = 0; i < csvData.Count; i++)
        {
            MonsterData.Attribute temp = new MonsterData.Attribute();
            //여기에 추가Name,stage,no,maxHP,moveSpeed,ave,feature1,feature2
            temp.name = (string)csvData[i]["Name"];
            temp.stage = (int)csvData[i]["stage"];
            temp.no = (int)csvData[i]["no"];
            temp.maxHP = (int)csvData[i]["maxHP"];
            temp.moveSpeed = (float)csvData[i]["moveSpeed"];
            temp.feature1 = (string)csvData[i]["feature1"];
            temp.feature2 = (float)csvData[i]["feature2"];


            data.list.Add(temp);
 
        }
       
           

          
        //위에서 생성된 SciprtableObject의 파일을 찾음
        ScriptableObject obj =
            AssetDatabase.LoadAssetAtPath(monsterExportPath, typeof(ScriptableObject)) as ScriptableObject;
        //디스크에 쓰기
        EditorUtility.SetDirty(obj);
    }

    /// <summary>
    /// Stage 정보를 ScriptableObject만듬
    /// </summary>
    static void MakeStageData()
    {
        //SciprtableObject를 생성
        StageData data = ScriptableObject.CreateInstance<StageData>();
        //ScriptableObject를 파일로 만듬
        AssetDatabase.CreateAsset((ScriptableObject)data, stageExportPath);
        //수정 불가능하게 설정(에디터에서 수정 하게 하려면 주석처리)
        data.hideFlags = HideFlags.NotEditable;

        //자료를 삭제(초기화)
        data.list.Clear();




        //CSVRead
        List<Dictionary<string,object>> csvData = CSVReader.Read("CSV/Stage");

        for (int i = 0; i < csvData.Count; i++)
        {
            StageData.Stage temp = new StageData.Stage();
            //여기에 추가Name,stage,no,maxHP,moveSpeed,ave,feature1,feature2
            temp.type = (int)csvData[i]["type"];
            temp.pos[0] = (int)csvData[i]["0"];
            temp.pos[1] = (int)csvData[i]["1"];
            temp.pos[2] = (int)csvData[i]["2"];
            temp.pos[3] = (int)csvData[i]["3"];
            temp.pos[4] = (int)csvData[i]["4"];
            temp.pos[5] = (int)csvData[i]["5"];
            temp.pos[6] = (int)csvData[i]["6"];

            data.list.Add(temp);

        }




        //위에서 생성된 SciprtableObject의 파일을 찾음
        ScriptableObject obj =
            AssetDatabase.LoadAssetAtPath(stageExportPath, typeof(ScriptableObject)) as ScriptableObject;
        //디스크에 쓰기
        EditorUtility.SetDirty(obj);
    }

	/// <summary>
	/// 주인공 정보를 ScriptableObject만듬
	/// </summary>
	static void MakeWeaponData()
	{
		//SciprtableObject를 생성
		WeaponData data = ScriptableObject.CreateInstance<WeaponData>();
		//ScriptableObject를 파일로 만듬
		AssetDatabase.CreateAsset((ScriptableObject)data, weaponExportPath);
		//수정 불가능하게 설정(에디터에서 수정 하게 하려면 주석처리)
		data.hideFlags = HideFlags.NotEditable;

		//자료를 삭제(초기화)
		data.list.Clear();

		//CSVRead
		List<Dictionary<string,object>> csvData = CSVReader.Read("CSV/Weapon");

		for (int i = 0; i < csvData.Count; i++)
		{
			WeaponData.Attribute temp = new WeaponData.Attribute();
			// ItemNo, Type, isMelee , feature,itemHP itemDamage  itemCriticalChance itemCriticalHit 
			// itemAttackSpeed  Slot1  Velue1 Slot2  Velue2
			temp.itemNo = (string)csvData[i]["ItemNo"];
			temp.itemType = (string)csvData[i]["Type"];
			temp.isMelee = (bool)csvData[i]["isMelee"];
			temp.feature = (string)csvData[i]["feature"];
			temp.itemHP = (int)csvData[i]["itemHP"];
			temp.itemDamage = (int)csvData[i]["itemDamage"];
			temp.itemCriticalChance = (float)csvData[i]["itemCriticalChance"];
			temp.itemCriticalHit = (float)csvData[i]["itemCriticalHit"];
			temp.itemAttackSpeed = (float)csvData[i]["itemAttackSpeed"];
			temp.slot1 = (string)csvData [i] ["Slot1"];
			temp.value1 = (string)csvData [i] ["Velue1"];
			temp.slot2 = (string)csvData [i] ["Slot2"];
			temp.value2 = (string)csvData [i] ["Velue2"];


			data.list.Add(temp);

		}
		//위에서 생성된 SciprtableObject의 파일을 찾음
		ScriptableObject obj =
			AssetDatabase.LoadAssetAtPath(weaponExportPath, typeof(ScriptableObject)) as ScriptableObject;
		//디스크에 쓰기
		EditorUtility.SetDirty(obj);
	}

	/// <summary>
	/// 주인공 정보를 ScriptableObject만듬
	/// </summary>
	static void MakeEquipmentData()
	{
		//SciprtableObject를 생성
		EquipmentData data = ScriptableObject.CreateInstance<EquipmentData>();
		//ScriptableObject를 파일로 만듬
		AssetDatabase.CreateAsset((ScriptableObject)data, equipmentExportPath);
		//수정 불가능하게 설정(에디터에서 수정 하게 하려면 주석처리)
		data.hideFlags = HideFlags.NotEditable;

		//자료를 삭제(초기화)
		data.list.Clear();

		//CSVRead
		List<Dictionary<string,object>> csvData = CSVReader.Read("CSV/Equipment");

		for (int i = 0; i < csvData.Count; i++)
		{
			EquipmentData.Attribute temp = new EquipmentData.Attribute();
			// ItemNo, Type, isMelee , feature,itemHP itemDamage  itemCriticalChance itemCriticalHit 
			// itemAttackSpeed  Slot1  Velue1 Slot2  Velue2
			temp.itemNo = (string)csvData[i]["ItemNo"];
			temp.itemType = (string)csvData[i]["Type"];
			temp.isMelee = (bool)csvData[i]["isMelee"];
			temp.feature = (string)csvData[i]["feature"];
			temp.itemHP = (int)csvData[i]["itemHP"];
			temp.itemDamage = (int)csvData[i]["itemDamage"];
			temp.itemCriticalChance = (float)csvData[i]["itemCriticalChance"];
			temp.itemCriticalHit = (float)csvData[i]["itemCriticalHit"];
			temp.itemAttackSpeed = (float)csvData[i]["itemAttackSpeed"];
			temp.slot1 = (string)csvData [i] ["Slot1"];
			temp.value1 = (string)csvData [i] ["Velue1"];
			temp.slot2 = (string)csvData [i] ["Slot2"];
			temp.value2 = (string)csvData [i] ["Velue2"];

			data.list.Add(temp);

		}

		//위에서 생성된 SciprtableObject의 파일을 찾음
		ScriptableObject obj =
			AssetDatabase.LoadAssetAtPath(equipmentExportPath, typeof(ScriptableObject)) as ScriptableObject;
		//디스크에 쓰기
		EditorUtility.SetDirty(obj);
	}


}