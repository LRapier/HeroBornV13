using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPickup : MonoBehaviour
{
    public GameBehavior gameManager;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Loot collected!");
        }
        gameManager.Items += 1;
        gameManager.PrintLootReport();
    }
}
