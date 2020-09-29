using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoretext;
    public float playerScore;

    void Start()
    {
        playerScore = 0;
    }
    // Update is called once per frame
    void Update()
    {
        playerScore = Cutting.score;
        scoretext.text = "Score" + "\n" + playerScore;
    }
}
