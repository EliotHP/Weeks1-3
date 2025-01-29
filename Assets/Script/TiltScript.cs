using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class TiltScript : MonoBehaviour
{
    [Range(0f, 1f)]
    public float t;
    public Transform start;
    public Transform end;
    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        t = -mousePos.x;

    }
}
