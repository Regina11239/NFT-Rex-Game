using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftLeft: MonoBehaviour
{
    public float speed;
    public float start;
    public float end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if (transform.position.x < end)
        {
            if (gameObject.tag == "obstacle" || gameObject.tag == "cactus3")
            {
                // trophy 1 : have passed three big cacti
                if (gameObject.tag == "cactus3") Achievement.obstacleCount += 1;
                Destroy(gameObject);

                // Check if cacti achievements are achieved
                if(!Achievement.achievements[2])
                {
                    if(Achievement.obstacleCount == 5) Achievement.achievements[0] = true;
                    if(Achievement.obstacleCount == 10) Achievement.achievements[1] = true;
                    if(Achievement.obstacleCount == 15) Achievement.achievements[2] = true;
                }
            }
            else
            {
                transform.position = new Vector2(start, transform.position.y);
            }
        }
    }
}