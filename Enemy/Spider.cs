using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public override void Update()
    {

    }

    public override void Attack()
    { //uses its own implementation of the Attack function
        base.Attack(); //runs original method
    }


}
