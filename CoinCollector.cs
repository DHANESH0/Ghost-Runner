using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    private float Coins = 0;

    public Text Scoretext;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Coins")
        {
            Coins++;
            Destroy(collision.gameObject);
            Scoretext.text = Coins.ToString();
        }
    }
}
