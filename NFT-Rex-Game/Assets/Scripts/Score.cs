using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;

    float timer;
    float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        maxTime = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTime) {
            Achievement.score++;
            scoreText.text = Achievement.score.ToString("00000");
            timer = 0;
        }
        // Check if score achievements are achieved
        if (!Achievement.achievements[5]) {
            if (Achievement.score == 500) 
                Achievement.achievements[4] = true;
            if (Achievement.score == 1000) 
                Achievement.achievements[5] = true;
        }
    }
}
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class Score : MonoBehaviour
// {
//     public Text timerText;
//     private float startTime;
//     // Start is called before the first frame update
//     void Start()
//     {
//         startTime = Time.time;
//     }

//     // Update is called once per frame
//     async void Update()
//     {
//         float t = Time.time - startTime;
//         string minutes = ((int) t / 60).ToString();
//         string seconds = (t % 60).ToString();
//         timerText.text = minutes + ":" + seconds;
//     }
// }
