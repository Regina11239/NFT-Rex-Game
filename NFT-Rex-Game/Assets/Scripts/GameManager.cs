using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GOPanel;
    //Text achievementNum;
    // Start is called before the first frame update
    void Start()
    {
        Achievement.score = 0;
        Achievement.obstacleCount = 0;
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GOPanel.SetActive(true);
        // Check if "dead at the beginning" is achieved
        if (Achievement.obstacleCount == 0 && !(Achievement.achievements[3]))
            Achievement.achievements[3] = true;
    }

    public void RestartGame() {
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit(){
        // Count Trophies
        // int trophyCount = 0;
        // foreach(bool achieved in Achievement.achievements) if (achieved) trophyCount++;
        // Show Results
        SceneManager.LoadScene("Achievement");
        // achievementNum = GetComponent<Text>();
        // achievementNum.text = trophyCount.ToString();
    }
    
}