using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopKeeper : MonoBehaviour
{
    [SerializeField]
    private GameObject _panel;
    private int item;
    private Player player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                UIManager.Instance.OpenShop(player.diamonds);
            }
            Debug.Log("Player Entered Shop");
            _panel.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Exited Shop");
            _panel.SetActive(false);
        }
    }

    public void SetItem(int itemID)
    {
        item = itemID;

        switch (itemID)
        {
            case 0:
                UIManager.Instance.UpdateShopSelection(115f);
                break;
            case 1:
                UIManager.Instance.UpdateShopSelection(39f);
                break;
            case 2:
                UIManager.Instance.UpdateShopSelection(-34f);
                break;
            case 3:
                UIManager.Instance.UpdateShopSelection(-117f);
                break;
        }
    }

    public void BuyItem()
    {
        switch (item)
        {
            case 0:
                if (CheckGems(30))
                {
                    Debug.Log("ADD LETTER");
                    player.diamonds -= 30;
                }

                else
                {
                    Debug.Log("NOT ENOUGH MONEY");
                }
                break;
            case 1:
                if (CheckGems(100))
                {
                    Debug.Log("ADD SNEAKERS");
                    player.diamonds -= 100;
                }
                else
                {
                    Debug.Log("NOT ENOUGH MONEY");
                }
                break;
            case 2:
                if (CheckGems(2))
                {
                    Debug.Log("ADD DUSY BUNNY");
                    player.diamonds -= 2;
                }
                else
                {
                    Debug.Log("NOT ENOUGH MONEY");
                }
                break;
            case 3:
                if (CheckGems(2400))
                {
                    Debug.Log("ADD KEY TO CASTLE");
                    player.diamonds -= 2400;
                }
                else
                {
                    Debug.Log("NOT ENOUGH MONEY");
                }
                break;
        }
    }

    public bool CheckGems(int gemCount)
    {
        if (player.diamonds >= gemCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //buyitem method
    //check if player gems is greater than or equal to
    //award item if yes, subtract cost from player gem
    //close shop if no


}
