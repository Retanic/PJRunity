using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class LoadScene : MonoBehaviour
{
    
    public void help()
    {
        SceneManager.LoadScene("Help");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void menu2()
    {
        SceneManager.LoadScene("MainMenu2");
        Speed.i = 1;
    }
    public void endless()
    {
        SceneManager.LoadScene("Endless Scene");
        ScoreManager.scorecount = 0f;
        Speed.i = 1;
    }
    public void main()
    {
        SceneManager.LoadScene("MainMenu");
        Speed.i = 1;
    }
    public void coop()
    {
        SceneManager.LoadScene("2Play");
        Speed.i = 1;
    }
    public void Begin()
    {
        SceneManager.LoadScene("Begin2P");
        Speed.i = 1;
    }
    public void Begin1()
    {
        SceneManager.LoadScene("BeginEndless");
        Speed.i = 1;
    }
    public void shop()
    {
        SceneManager.LoadScene("Shop");
        Speed.i = 1;
    }
    public void restart2()
    {
        SceneManager.LoadScene("Endless Scene");
        Speed.i = 1;
    }
    public void menumode()
    {
        SceneManager.LoadScene("Mode2play");
        Speed.i = 1;
    }
    public void mode2()
    {
        SceneManager.LoadScene("2Play2");
        Speed.i = 1;
    }
    public void Begin3()
    {
        SceneManager.LoadScene("Begin2P2");
        Speed.i = 1;
    }
    public void Option()
    {
        SceneManager.LoadScene("Option");
        Speed.i = 1;
    }


}