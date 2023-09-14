using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MossGiant : Enemy
{
    private bool A = true;

    public void Start()
    {
        A = true;
    }
    // Start is called before the first frame update
    public override void Update()
    {
        float step = speed * Time.deltaTime;
        if (A == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed);
            if (transform.position == pointB.position)
            {
                A = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed);
            if (transform.position == pointA.position)
            {
                A = true;
            }
        }
        // move towards
        // lerp
        // if current pos = pointA
        // move to pointB
        // else if current position = pointB,
        // move to pointA



    }
}
