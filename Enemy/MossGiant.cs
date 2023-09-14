using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MossGiant : Enemy
{
    private bool atPointA = true;

    public void Start()
    {
        atPointA = true;
    }
    // Start is called before the first frame update
    public override void Update()
    {
        if (atPointA == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);
            if (transform.position == pointB.position)
            {
                atPointA = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);
            if (transform.position == pointA.position)
            {
                atPointA = true;
            }
        }

    }
}
