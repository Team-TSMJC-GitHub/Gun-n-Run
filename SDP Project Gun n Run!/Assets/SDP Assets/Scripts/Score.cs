using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    //public Text hiScoreText;

    public float scoreCount;
    //public float hiScoreCount;

    public float pointsPerSecond;

    //public float gameTime;

    public bool scoreIncreasing;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float finalscore = scoremanager();
        testScore(finalscore);
        /*if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
        }*/

        //hiScoreText.text = "Highscore: " + Mathf.Round(hiScoreCount);
    }

    public void testScore(float score)
    {
        if (score > 1f)
        {
            Debug.Log("Score is incrementing.");
        }
    }

    public float scoremanager()
    {
        scoreCount += pointsPerSecond * Time.deltaTime;
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        return scoreCount;
    }
}