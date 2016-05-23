using UnityEngine;
using System.Collections;

public class ItemClass : MonoBehaviour {

	public string itemType;
	public string imagePath;

	public ItemClass(string type, string path){
		itemType = type;
		imagePath = path;

	}

	public ItemClass(string type){
		itemType = type;


	}

}
