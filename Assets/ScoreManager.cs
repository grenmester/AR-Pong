using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's score.


    public Text text;                      // Reference to the Text component.


    //void Awake()
    void Start()
    {
        // Set up the reference.
        //text = gameObject.GetComponent<Text>();
        text.text = "";
        // Reset the score.
        score = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
    }

    public void updateScore()
    {
        score++;
    }
}
