using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class SlotList : MonoBehaviour {

	public List<GameObject> Slots = new List<GameObject>();
	public List<Item> Items = new List<Item>();
	public GameObject slots ;
	public GameObject Content;
	ItemDatabase database;

	int x = 0;
	int y = 0;
	int slotAmount = 0;
	int listNum = 20; // Use to modify ListUI height
	int [] spriteNum = new int[10] ; // Store sprite image number
	string [] pathArr = new string[10]; // Store each path
	int jNum = 1; // Store _weaponData list initial value

	public string spritePath; // Assign each path

	public string arrowPath = "Weapon/Arrow/Arrow";
	public string starPath = "Weapon/Star/Star";
	public string axePath = "Weapon/Axe/Axe";
	public string bowPath = "Weapon/Bow/Bow";
	public string clawPath = "Weapon/Claw/Claw";
	public string daggerPath = "Weapon/Dagger/Dagger";
	public string katerPath = "Weapon/Kater/Kater";
	public string macePath = "Weapon/Mace/Mace";
	public string shieldPath = "Weapon/Shield/Shield";
	public string spearPath = "Weapon/Spear/Spear";
	public string staffPath = "Weapon/Staff/Staff";
	public string swordPath = "Weapon/Sword/Sword";
	public string wandPath = "Weapon/Wand/Wand";
	public string accessoryPath = "Equipment/accessory/accessory";
	public string armorPath = "Equipment/armor/armor_";
	public string glovePath = "Equipment/glove/glove_";
	public string bootPath = "Equipment/boot/boot_";
	public string helmetPath = "Equipment/helmet/helmet_";
	public string ringPath = "Equipment/ring/ring_";
	public string shoesPath = "Equipment/boot/boot_";

		

	[HideInInspector]
	public WeaponData.Attribute _weaponData;
	public EquipmentData.Attribute _equipmentData;

	// Use this for initialization
	void Start () {
		database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
		// toolTip = GameObject.FindGameObjectWithTag("ToolTip").GetComponent<GameObject>();
		//draggedItemGameObject = GameObject.FindGameObjectWithTag("droppedItemIcon").GetComponent<GameObject>();

		Melee1WeaponListClick ();



	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ListClick(string type) { // Make item list

		foreach (Transform child in transform) {
			GameObject.Destroy(child.gameObject);
		}
			
		Slots.Clear(); // Clear all element
		Items.Clear();
		Content.GetComponent<RectTransform> ().sizeDelta = new Vector3(790, 350 * (listNum / 3.5f), 1); // Modify ListUI height
		int count = 0;
		for (int i = 1, j = jNum; i <= spriteNum[count] && j != 382; i++, j++) // i means image number, j means dataList number
		{
			if (i < spriteNum [count]) { // Assign path
				spritePath = pathArr [count];
			} else if (i == spriteNum[count]){ 
				count++;
				i = 1;
			}else if (spriteNum[count] == 0){
				break;
			}else {
				i = spriteNum[count];
			}

			GameObject slot = (GameObject)Instantiate(slots); // Make slot(item) list
			slot.GetComponent<Slot>().slotNumber = slotAmount;
			Slots.Add(slot);
			Items.Add(new Item(Item.ItemType.All));
			slot.transform.parent = this.gameObject.transform;
			slot.name = "slot" + i;
			slot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>(spritePath+i);

			if (type == "weapon") { // Check weapon or equipment data
				_weaponData = DataManager.Instance.weaponData.list [j-1];
				slot.gameObject.transform.GetChild (1).GetComponent<Text> ().text = _weaponData.itemNo;
			} else {
				_equipmentData = DataManager.Instance.equipmentData.list [j-1];
				slot.gameObject.transform.GetChild (1).GetComponent<Text> ().text = _equipmentData.itemNo;
			}
			slot.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
			slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
			y -= 105;
			slotAmount++;
		}
	}


	public void Melee1WeaponListClick() {
		initSpriteNum ();

		jNum = 1;
		listNum = 170;
		spriteNum [0] = 43;
		spriteNum [1] = 31;
		spriteNum [2] = 31;
		spriteNum [3] = 31;
		spriteNum [4] = 37;


		pathArr [0] = shieldPath;
		pathArr [1] = axePath;
		pathArr [2] = bowPath;
		pathArr [3] = clawPath;
		pathArr [4] = daggerPath;
		ListClick ("weapon");

	}

	public void Melee2WeaponListClick() {
		initSpriteNum ();

		jNum = 170;
		listNum = 210;
		spriteNum [0] = 21;
		spriteNum [1] = 37;
		spriteNum [2] = 21;
		spriteNum [3] = 31;
		spriteNum [4] = 37;
		spriteNum [5] = 31;

		pathArr [0] = katerPath;
		pathArr [1] = macePath;
		pathArr [2] = spearPath;
		pathArr [3] = staffPath;
		pathArr [4] = swordPath;
		pathArr [5] = wandPath;
		ListClick ("weapon");

	}

	public void MissleWeaponListClick() {
		initSpriteNum ();
		
		jNum = 342;
		listNum = 40;
		spriteNum [0] = 21;
		spriteNum [1] = 21;

		pathArr [0] = arrowPath;
		pathArr [1] = starPath;
		ListClick ("weapon");
	}

	public void HeadListClick() {
		initSpriteNum ();

		jNum = 235;
		listNum = 72;
		spriteNum [0] = 72;

		pathArr [0] = helmetPath;
		ListClick ("equipment");
	}

	public void ClotheListClick() {
		initSpriteNum ();

		jNum = 57;
		listNum = 108;
		spriteNum [0] = 108;

		pathArr [0] = armorPath;
		ListClick ("equipment");
	}

	public void BeltListClick() {
		initSpriteNum ();

	}

	public void ShoesListClick() {
		initSpriteNum ();

		jNum = 165;
		listNum = 29;
		spriteNum [0] = 29;

		pathArr [0] = bootPath;
		ListClick ("equipment");
	}

	public void GloveListClick() {
		initSpriteNum ();

		jNum = 194;
		listNum = 41;
		spriteNum [0] = 41;

		pathArr [0] = glovePath;
		ListClick ("equipment");
	}

	public void RingListClick() {
		initSpriteNum ();

		jNum = 307;
		listNum = 75;
		spriteNum [0] = 75;

		pathArr [0] = ringPath;
		ListClick ("equipment");
	}

	public void NecklaceListClick() {
		initSpriteNum ();

		jNum = 1;
		listNum = 55;
		spriteNum [0] = 55;

		pathArr [0] = accessoryPath;
		ListClick ("equipment");
	}

	public void initSpriteNum(){
		for (int i = 0; i < 10; i++) {
			spriteNum [i] = 0;
		}
	}
}
