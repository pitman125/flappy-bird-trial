using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameConditions : MonoBehaviour
{
    private int test = 0;
    public Text score;
    public Text gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        score.text = test.ToString();
        test++;
    }
    
    void  OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "lose")
        {
            gameOver.gameObject.SetActive(true);
        }
    }
}
