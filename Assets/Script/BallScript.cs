using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    float speedX = 0.1f;
    float speedY = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        speedX = Random.Range(0.05f, 0.2f);
        speedY = Random.Range(0.05f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speedX;
        pos.y += speedY;
        Vector2 ballInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        if (ballInScreenSpace.x < 0 || ballInScreenSpace.x > Screen.width) 
        {
            speedX = speedX * -1;
        }
        if (ballInScreenSpace.y < 0 || ballInScreenSpace.y > Screen.height) 
        {
            speedY = speedY * -1;
        }
        transform.position = pos;
    }
}
