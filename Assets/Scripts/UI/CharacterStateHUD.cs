using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharacterStateHUD : MonoBehaviour
{



	public Text levelText;
	public Text expText;
	public Text attackText;
	public Text attackSpeedText;
	public Text bulletCountText;
	public Text criticalText;

	public float level = 1;
	public float exp = 100;
	public float attack = 10;
	public float attackSpeed = 1.0f;
	public float bulletCount = 5;
	public float critical = 1;
	public GameObject hud;

	void OnEnable()
	{
		hud = GameObject.FindGameObjectWithTag("CharacterStateHUD");

	}

	void Update()
	{
		levelText.text = "Level : " + level;
		expText.text = "Exp : " + exp;
		attackText.text = "Attack : " + attack;
		attackSpeedText.text = "AttackSpeed : " + attackSpeed;
		bulletCountText.text = "Bullet : " + bulletCount;
		criticalText.text = "Critical : " + critical + "%";

	}



}
