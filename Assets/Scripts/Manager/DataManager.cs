using UnityEngine;
using System.Collections;

public class DataManager : MonoBehaviour
{

    protected static DataManager instance;
    public PlayerData playerData;
    public MonsterData monsterData;
    public StageData stageData;
	public EquipmentData equipmentData;
	public WeaponData weaponData;

    public static string nextSceneName;

    public static DataManager Instance
    {
        get
        { 
            return instance;
        }

    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            playerData = Resources.Load("Data/PlayerData")as PlayerData;
            monsterData = Resources.Load("Data/MonsterData")as MonsterData;
            stageData = Resources.Load("Data/StageData")as StageData;
			equipmentData = Resources.Load("Data/EquipmentData")as EquipmentData;
			weaponData = Resources.Load("Data/WeaponData")as WeaponData;

        }
        else
        {
            Destroy(gameObject);
        }





    }


}
