using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score2Dd : MonoBehaviour
{
    public GUIText scoreText;
    public int coinValue;

    private int score;

    void Start()
    {
        UpdateScore(0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bomb")
        {
            UpdateScore(-100);
        }
        if (other.tag == "Coin")
        {
            UpdateScore(50);
        }
        Destroy(other);
    }

    void UpdateScore(int score)
    {
        GameStatusScript.score += score;
        scoreText.text = "SCORE:\n" + GameStatusScript.score;
    }
}
