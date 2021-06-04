using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Player1 : MonoBehaviour, IUnityAdsListener
{
    string gameId = "4013755";
    bool testMode = true;
    string placementid = "Restart2Play";
    public static int PlayerLive = 1;
    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }
    void Update()
    {
        if (transform.position.y <= -6.6f)
        {
            Die();
        }
        else if (transform.position.y >= 6f)
        {
            Die();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Block"))
        {
            Die();

        }
        if (collision.tag == ("DGUP")) ;
        {
            Die();

        }
        if (collision.tag == ("DGDOWN")) ;
        {
            Die();

        }
    }
    void Die()
    {

       // Destroy(gameObject);
        //ShowAds();
        PlayerLive--;
        if (PlayerLive <= 0)
        {
            Data.RewardScene = 1;
            Destroy(gameObject);
            ShowAds();
            SceneManager.LoadScene("P2Win");
        }

    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            // Reward the user for watching the ad to completion.
            SceneManager.LoadScene("P2Win");
        }
        else if (showResult == ShowResult.Skipped)
        {
            SceneManager.LoadScene("P2Win");
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.Log("Ad error");
        }
    }
    void ShowAds()
    {
        if (Advertisement.IsReady(placementid))
        {
            Advertisement.Show(placementid);
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
       
    }

    public void OnUnityAdsDidError(string message)
    {
        
    }

    public void OnUnityAdsDidStart(string placementId)
    {
    }
}
