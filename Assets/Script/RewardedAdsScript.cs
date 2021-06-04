using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RewardedAdsScript : MonoBehaviour, IUnityAdsListener
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
            if(Data.RewardScene == 0)
            {
                SceneManager.LoadScene("Endless Scene");
            }
            if(Data.RewardScene == 1)
            {
                SceneManager.LoadScene("P2Win");
            }
            if(Data.RewardScene == 2)
            {
                SceneManager.LoadScene("P1Win");
            }
            // Reward the user for watching the ad to completion.
            
        }
        else if (showResult == ShowResult.Skipped)
        {
   
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
