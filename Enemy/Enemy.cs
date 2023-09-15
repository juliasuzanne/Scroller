using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected Vector3 currentTarget;
    protected Animator animator;
    protected SpriteRenderer sp;
    [SerializeField]
    protected int health;
    [SerializeField]
    protected float speed;
    [SerializeField]
    protected int gems; //only inherited classes can modify, outside scripts cannot see it (private)
    [SerializeField]
    protected Transform pointA, pointB; //waypoints for AI behavior

    public virtual void Init()
    {
        transform.position = pointA.position;
        animator = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }
    public virtual void Attack() //virtual keyword allows for functino to be rewritten
    {
        Debug.Log("My name is " + this.gameObject.name);
    }

    public virtual void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            return;
        }
        Movement();
    }

    public void Start()
    {
        Init();
    }

    public virtual void Movement()
    {
        if (currentTarget == pointA.position)
        {
            sp.flipX = true;

        }

        else if (currentTarget == pointB.position)
        {
            sp.flipX = false;

        }
        if (transform.position == pointA.position)
        {
            Debug.Log("At Point A");
            animator.SetBool("Idle", true);
            currentTarget = pointB.position;
        }
        else if (transform.position == pointB.position)
        {
            Debug.Log("At Point B");
            animator.SetBool("Idle", true);
            currentTarget = pointA.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

    }


}
