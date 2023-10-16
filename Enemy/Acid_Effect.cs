using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid_Effect : MonoBehaviour
{
    private Player player;

    void Start()
    {
        StartCoroutine("DestroyAfterSec");
    }
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision");
        if (other.gameObject.tag == "Player")
        {
            player = other.transform.GetComponent<Player>();
            player.Damage();
            Debug.Log("Player Collision");
            Destroy(this.gameObject);
        }
    }

    IEnumerator DestroyAfterSec()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
    //move left at 3m/s
    //detect a hit collision with player, deal damage with idamageable interface
    //destroy after 5s or on collision
}
