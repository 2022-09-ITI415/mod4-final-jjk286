using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    public int NumberOfCoins { get; private set; }

    public void CoinCollected()
    
    {
        NumberOfCoins++;
    }
}