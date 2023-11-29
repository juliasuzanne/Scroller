using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //instance run along all classes
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("UI Manager is null!");
            }

            return _instance;

        }
    }
    public Text playerGemCountText;
    public Image selectionImg;

    public void OpenShop(int gemCount)
    {
        playerGemCountText.text = "" + gemCount + "c";
    }

    public void Awake()
    {
        _instance = this;


    }
}
