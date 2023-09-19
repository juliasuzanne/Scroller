using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//only can inherit from one class, but can include as many interfaces as you want
public class MossGiant : Enemy, IDamageable
{

    public int Health { get; set; }
    // Use for initialization
    public override void Init()
    {
        base.Init();
        Health = base.health;
    }
    public void Damage()
    {
        Debug.Log("Damage");

        Debug.Log("Health is at " + Health);
        Health = Health - 1;
        if (Health < 1)
        {
            Destroy(this.gameObject);
        }

        animator.SetTrigger("Hit");
        isHit = true;
        animator.SetBool("InCombat", true);

    }

    public override void Movement()
    {
        base.Movement();

        Vector3 direction = player.transform.localPosition - transform.localPosition;
        Debug.Log("Side is " + direction.x);

        if (animator.GetBool("InCombat") == true && direction.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
        else if (animator.GetBool("InCombat") && direction.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
    }

}
