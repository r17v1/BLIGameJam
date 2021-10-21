using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score = 0;
    public TextMeshProUGUI ScoreBoard;

    void Start()
    {
        ScoreBoard.text = "Score : 0";
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreBoard.text = ("Score : "+score);
    }

    public void addScore(int points)
    {
        score += points;
    }
}
