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

    }

}
