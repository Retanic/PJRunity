using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total : MonoBehaviour
{
    Text scoretotal;
    // Use this for initialization
    void Start()
    {
        scoretotal = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        ScoreManager.scorecount = Mathf.Round(ScoreManager.scorecount);
        scoretotal.text = "Score : " + ScoreManager.scorecount;
    }
}
