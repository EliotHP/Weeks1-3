using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleScript : MonoBehaviour
{
   
    float speedX = -0.01f;
    [Range(0f, 1f)]
    public float t;
    public Transform start;
    public Transform end;
    public AnimationCurve curve;
    // Start is called before the first frame update
    void Start()
    {
        t = Random.Range(0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Currentpos = transform.position;
        Vector2 pos = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));

     
        Vector2 Lastpos = new Vector2(
            Currentpos.x + speedX, 
            pos.y                  
        );
 
        if (Lastpos.x < -20)
        {
            Lastpos.x = 2; 
        }

        transform.position = Lastpos;

        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0; 
        }
    }
}
