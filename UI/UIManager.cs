using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //instance run along all classes
    private static UIManager _instance;
    public static UIManager Instance;
    {
        get
        {
            if (_instance == nul)
            {
                Debug.LogError("UI Manager is null!");
            }
            return _instance;
        }
    }

    public void Awake()
    {
        _instance = this;
    }
}
