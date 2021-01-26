using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text scoreValue;
    public int wastepoints;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateValue();
    }

    void OnTriggerEnter2D (Collider2D other) {
        if(other.gameObject.tag == "paper")
        {
        score += wastepoints;
        UpdateValue();
        }
        else
        {
            score -= wastepoints*2;
            UpdateValue();
        }
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.tag == "plastic")
    //     {
    //         score -= wastepoints*2;
    //         UpdateValue();
    //     }
    // }

    // Update is called once per frame
    void UpdateValue()
    {
        scoreValue.text = "Score: " + score;
    }
}
