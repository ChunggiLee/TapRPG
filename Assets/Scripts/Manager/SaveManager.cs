using UnityEngine;
using System.Collections;
 
public class SaveManager : MonoBehaviour 
{
	    int currentScore;
	    int highScore;
	 
	    string currentPlayerName;
	    string highScorePlayerName;

		public WeaponData.Attribute _weaponData;
	 
	   /* void SaveData()
	    {
		        // 이런식으로 스트링키를 이용해서 값을 저장해줍니다.
		        PlayerPrefs.SetInt("Score", currentScore);
		        PlayerPrefs.SetInt("HighScore", currentScore);
		        PlayerPrefs.SetString("HighScoreName", currentPlayerName);
				
		}
	 
	    void GetData()
	    {
		        // 필요한 데이터를 불러올때는 이렇게 키값으로 불러오게 되죠.
		        highScore               = PlayerPrefs.GetInt("HighScore");
		        highScorePlayerName     = PlayerPrefs.GetString("HighScoreName", "N/A");
		}*/
}
