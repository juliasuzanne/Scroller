using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MossGiant : Enemy
{
    private Vector3 _currentTarget;
    public void Start()
    {
        transform.position = pointA.position;
    }
    // Start is called before the first frame update
    public override void Update()
    {
        Movement();

    }

    void Movement()
    {
        if (transform.position == pointA.position)
        {
            Debug.Log("At Point A");
            _currentTarget = pointB.position;
        }
        else if (transform.position == pointB.position)
        {
            Debug.Log("At Point B");
            _currentTarget = pointA.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, _currentTarget, speed * Time.deltaTime);

    }
}
