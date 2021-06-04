using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static float scorecount;
    public float pointPerSecond;
    int highscore;

    public Text HighScore;
    void Start()
    {
      //  scorecount = 0f;
        pointPerSecond = 1f;
        HighScore.text = ("HighScore : ") + PlayerPrefs.GetInt("Highscore1").ToString();
    }

        // Update is called once per frame
        void Update()
        {
            scoreText.text = "Score : " + (int)scorecount;
            scorecount += pointPerSecond * Time.deltaTime;
        highscore = (int)scorecount;
            if (PlayerPrefs.GetInt("Highscore1") <= highscore)
        {
            PlayerPrefs.SetInt("Highscore1", highscore);
        }
             
        }
       /*  void Show()
        {        
                HighScore.text = ("HighScore : ") + PlayerPrefs.GetFloat("HighSCore").ToString();
            
        }*/ 
    
}
