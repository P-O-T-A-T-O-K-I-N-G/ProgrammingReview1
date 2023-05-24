using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int lives;

    public TextMeshProUGUI livesText;

    public static int score;

    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;

        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives.ToString();

        scoreText.text = "Score: " + score.ToString();
    }
}
