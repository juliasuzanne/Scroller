using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MossGiant : Enemy
{
    private Vector3 _currentTarget;
    private Animator _animator;

    private SpriteRenderer sp;

    public void Start()
    {
        transform.position = pointA.position;
        _animator = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();

    }
    // Start is called before the first frame update
    public override void Update()
    {
        if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            return;
        }
        Movement();

    }

    void Movement()
    {
        if (transform.position == pointA.position)
        {
            Debug.Log("At Point A");
            sp.flipX = false;
            _animator.SetBool("Idle", true);
            _currentTarget = pointB.position;
        }
        else if (transform.position == pointB.position)
        {
            Debug.Log("At Point B");
            sp.flipX = true;
            _animator.SetBool("Idle", true);
            _currentTarget = pointA.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, _currentTarget, speed * Time.deltaTime);

    }
}
