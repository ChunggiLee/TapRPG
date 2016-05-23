using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour{

	public Item item; 
	Image itemImage;

	Text itemAmount;
	public int slotNumber;

	void Start()
	{
		itemAmount = gameObject.transform.GetChild(1).GetComponent<Text>();
		itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();

	}

	// Update is called once per frame
	void Update () {
		 
	}

}
