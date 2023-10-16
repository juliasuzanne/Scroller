using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy, IDamageable
{
  public int Health { get; set; }
  // Use for initialization
  public override void Init()
  {
    base.Init();
    Health = base.health;
  }

  public override void Movement()
  {
    //sit still
  }
  public void Damage()
  {
    Debug.Log("Damage");
  }

  public void Attack()
  {
    // instatiate acid effect
  }
}


