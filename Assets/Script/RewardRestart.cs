using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class RewardRestart : MonoBehaviour, IUnityAdsListener
{
    public Button myButton;
    string gameId = "4013755";
    string placementId = "Rewarded Android";
    bool testMode = true;
    //bool ready = false;
    // Start is called before the first frame update
    void Start()
    {
        //myButton.interactable = Advertisement.IsReady(placementId);
        //if (myButton) myButton.onClick.AddListener(ShowRewardedVideo);

        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);
    }

    // Implement a function for showing a rewarded video ad:
    public void ShowRewardedVideo(string p)
    {
        Advertisement.Show(p);
    }


    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, activate the button: 

    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            // Reward the user for watching the ad to completion.
            SceneManager.LoadScene("Endless Scene");
            ScoreManager.scorecount = 0f;
        }
        else if (showResult == ShowResult.Skipped)
        {
            SceneManager.LoadScene("Endless Scene");
            ScoreManager.scorecount = 0f;
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.Log("Ad error");
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }
}
