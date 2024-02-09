using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopKeeper : MonoBehaviour
{
    [SerializeField]
    private GameObject _panel;

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
}
