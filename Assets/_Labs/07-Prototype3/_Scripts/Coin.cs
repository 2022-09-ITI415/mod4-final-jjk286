using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter (Collider other) 
    {
        ItemCollector itemCollector = other.GetComponent<ItemCollector> ();

        if (itemCollector != null) 
        {
            itemCollector.CoinCollected();
            gameObject.SetActive(false);
        }
    }
}
