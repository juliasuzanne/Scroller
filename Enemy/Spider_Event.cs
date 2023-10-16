using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider_Event : MonoBehaviour
{

    private void Start()
    {
        //assign handle to spider component, call fire method in spider component
        //use handle to call attack method on spider
    }
    public void Fire()
    {
        //tell spider to fire
        Debug.Log("Spider should fire");
    }
}
