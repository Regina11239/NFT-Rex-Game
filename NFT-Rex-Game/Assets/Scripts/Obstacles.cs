using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float maxTime;
    float timer;

    public GameObject cactus1;
    public GameObject cactus2;
    public GameObject cactus3;

    int chooseObstacle;
    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            GenerateObstacle();
            timer = 0;
        }
    }

    void GenerateObstacle()
    {
        chooseObstacle = Random.Range(1, 4);
        if (chooseObstacle == 1) { GameObject newObstacle = Instantiate(cactus1); }
        if (chooseObstacle == 2) { GameObject newObstacle = Instantiate(cactus2); }
        if (chooseObstacle == 3) { GameObject newObstacle = Instantiate(cactus3); }
    }
}
