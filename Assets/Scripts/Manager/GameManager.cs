using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public GameObject[] aliveMonsters;
    public StageManager stageManager;
    public KillZone killZone;
    public GameObject gameOver;

    public bool isGameOver=false;


    void OnEnable()
    {
        stageManager = GameObject.FindGameObjectWithTag("Manager").GetComponentInChildren<StageManager>();
        gameOver = GameObject.FindGameObjectWithTag("GameOver");
 


        StartCoroutine(CheckMonster());
        gameOver.SetActive(false);
    }

    IEnumerator CheckMonster()
    {
        while (true)
        {

            aliveMonsters = GameObject.FindGameObjectsWithTag("Monster");

            if (aliveMonsters.Length == 0&&isGameOver==false)
            {
                yield return new WaitForSeconds(1.5f);
                stageManager.CreateStage();

            }



           
            yield return null;



        }

    }

    void Update()
    {
        if (killZone.killZoneNum >= 10 )
        {
            for (int i = 0; i < aliveMonsters.Length; i++)
            {
                aliveMonsters[i].SetActive(false);
            }
            isGameOver = true;
            gameOver.SetActive(true);

           
        }

    }





}
