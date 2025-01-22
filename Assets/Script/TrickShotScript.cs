using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TrickShotScript : MonoBehaviour
{
    [Range(0f, 1f)]
    public float t;
    public Transform start;
    public Transform end;
    public AnimationCurve curve;
    float speedX = 0.1f;
    float speedY = 0.001f;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        Vector2 pos = transform.position;
        pos.x += speedX;
        pos.y += speedY;
        Vector2 SquareInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        if (SquareInScreenSpace.x < 0 || SquareInScreenSpace.x > Screen.width)
        {
            speedX = speedX * -1;
        }
        transform.position = pos;

        if (Input.GetKey("space"))
        {
            speedY = t;
        }
        if (t > 1)
        {
            t = 0;
        }
    }

}
