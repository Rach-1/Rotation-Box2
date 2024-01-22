
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Box : MonoBehaviour
{
    float t, dt = 0.1f, dist, distThreshold = 0.01f;
    Vector3 newPos, oldPos;
    public bool isStopped;

    private float positionX;
    private float positionY;
    private float positionX1;
    private float positionY1;
    private float timeShot;

    [SerializeField] float StartTimeShot;

    public bool IsGrounded;
    public bool Exit = false;

    private void Start() 
    {
        oldPos = transform.position; 
    }

    private void Update()
    {
        if (!Exit)
        {
            t -= Time.deltaTime;
            if (t < 0)
            {
                t = dt;
                newPos = transform.position;
                dist = Vector3.SqrMagnitude(newPos - oldPos);
                isStopped = dist < distThreshold;
                oldPos = newPos;
            }
        }
        else
        {
            isStopped = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isStopped = true;
    }

}
