using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountDown : MonoBehaviour
{
    public GameObject text;
    private float secondsLeft = 30;
    private bool takingAway = false;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(LessTimer());
        }
    }
    IEnumerator LessTimer()
    {
        takingAway = true;
        yield return new WaitForSeconds(1f);
        secondsLeft -= 1;
        text.GetComponent<Text>().text = "00:" + secondsLeft;
        takingAway = false;
    }
}
