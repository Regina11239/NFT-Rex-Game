using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalResult : MonoBehaviour
{
    Text finalResult;
    public int trophyCount;
    // Start is called before the first frame update
    void Start()
    {
        trophyCount = 0;
        foreach (bool achieved in Achievement.achievements) if (achieved) trophyCount++;
        finalResult = GetComponent<Text>();
        finalResult.text = "Number of Achievements: " + trophyCount.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
