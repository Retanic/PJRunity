using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Player2 : MonoBehaviour, IUnityAdsListener
{
    string gameId = "4013755";
    bool testMode = true;
    string placementid = "Restart2Play2";
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

        Destroy(gameObject);
        PlayerLive--;
        if (PlayerLive <= 0)
        {
            Data.RewardScene = 2;
            Destroy(gameObject);
            ShowAds();
            SceneManager.LoadScene("P1Win");
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
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        throw new System.NotImplementedException();
    }
}
