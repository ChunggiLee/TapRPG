using System;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour, IPointerDownHandler
{
	SlotList slotList;
	public int itemNumber;
	Boolean isWearRing = false;

	void start(){
		slotList = GameObject.FindGameObjectWithTag("SlotList").GetComponent<SlotList>();

	}

	public void OnPointerDown(PointerEventData data)
	{
		slotList = GameObject.FindGameObjectWithTag("SlotList").GetComponent<SlotList>();
		//Debug.Log ("index : " + slotList.Items[itemNumber].itemType);
		//Debug.Log ("imagePath : " + slotList.Items[itemNumber].imagePath);
		Debug.Log ("itemNumber-slotList.jNum+1 : " + (itemNumber) );

	
		/*if (slotList.Items [itemNumber-slotList.jNum+1].itemType == "Bow" ||
			slotList.Items [itemNumber-slotList.jNum+1].itemType == "Axe" ||
			slotList.Items [itemNumber-slotList.jNum+1].itemType == "Claw" ||
			slotList.Items [itemNumber-slotList.jNum+1].itemType == "Dagger" ||
			slotList.Items [itemNumber-slotList.jNum+1].itemType == "Katar" ||
			slotList.Items [itemNumber-slotList.jNum+1].itemType == "Mace" ||
			slotList.Items [itemNumber-slotList.jNum+1].itemType == "Spear" ||
			slotList.Items [itemNumber-slotList.jNum+1].itemType == "Staff" ||
			slotList.Items [itemNumber-slotList.jNum+1].itemType == "Sword" ||
			slotList.Items [itemNumber-slotList.jNum+1].itemType == "Wand" ||
			slotList.Items [itemNumber-slotList.jNum+1].itemType == "star") {
			slotList.mainWeaponSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items [itemNumber-slotList.jNum+1].imagePath);

		} else if (slotList.Items [itemNumber-slotList.jNum+1].itemType == "Arrow" || slotList.Items [itemNumber-slotList.jNum+1].itemType == "Shield") {
			slotList.subWeaponSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items[itemNumber-slotList.jNum+1].imagePath);
		} */

		if (slotList.Items [itemNumber].itemType == "Bow" ||
		    slotList.Items [itemNumber].itemType == "Axe" ||
		    slotList.Items [itemNumber].itemType == "Claw" ||
		    slotList.Items [itemNumber].itemType == "Dagger" ||
		    slotList.Items [itemNumber].itemType == "Katar" ||
		    slotList.Items [itemNumber].itemType == "Mace" ||
		    slotList.Items [itemNumber].itemType == "Spear" ||
		    slotList.Items [itemNumber].itemType == "Staff" ||
		    slotList.Items [itemNumber].itemType == "Sword" ||
		    slotList.Items [itemNumber].itemType == "Wand" ||
		    slotList.Items [itemNumber].itemType == "Star") {
			slotList.mainWeaponSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items [itemNumber].imagePath);

		} else if (slotList.Items [itemNumber].itemType == "Arrow" || slotList.Items [itemNumber].itemType == "Shield") {
			slotList.subWeaponSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items [itemNumber].imagePath);
		} else if (slotList.Items [itemNumber].itemType == "accessory") {
			slotList.necklaceSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items[itemNumber].imagePath);
		} else if (slotList.Items [itemNumber].itemType == "armor") {
			slotList.clotheSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items[itemNumber].imagePath);
		} else if (slotList.Items [itemNumber].itemType == "boot") {
			slotList.shoesSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items[itemNumber].imagePath);
		} else if (slotList.Items [itemNumber].itemType == "glove") {
			slotList.handsSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items[itemNumber].imagePath);
		} else if (slotList.Items [itemNumber].itemType == "ring") {
			if (isWearRing == false) {
				slotList.rightRingSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items [itemNumber].imagePath);
				isWearRing = true;
			} else {
				slotList.leftRingSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items [itemNumber].imagePath);
				isWearRing = false;
			}
		} else if (slotList.Items [itemNumber].itemType == "helmat") {
			slotList.headSlot.gameObject.transform.GetChild (0).GetComponent<Image> ().sprite = Resources.Load<Sprite> (slotList.Items[itemNumber].imagePath);
	} 
	}	
}
	