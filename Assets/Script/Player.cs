using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static int PlayerLive = 2;
    string placementid = "video";
    public Text lifeText;

    public Shake shake;

    void Start()

    {
        PlayerLive = 2;
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();

    }

    void Update()
    {
        if (transform.position.y <= -6.6f)
        {
            Destroy(gameObject);
            //ShowAds();
            SceneManager.LoadScene("GameOver");
            PlayerLive = 2;
        }
        else if (transform.position.y >= 6f)
        {
            Destroy(gameObject);
           // ShowAds();
            SceneManager.LoadScene("GameOver");
            PlayerLive = 2;
        }
        else if (transform.position.x <= -9.65f)
        {
            Destroy(gameObject);
          //  ShowAds();
            SceneManager.LoadScene("GameOver");
            PlayerLive = 2;
        }
        lifeText.text = "Life : " + (int)PlayerLive;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Block"))
        {
            Die();
          
        }
        if (collision.tag == ("DGUP"))
        {
            
            Die();
            
        }
        if (collision.tag == ("DGDOWN"))
        {
            Die();
          
        }
        if (collision.tag == ("PowerUP"))
        {
            PlayerLive++;

        }
    }

   
    void Die()
    {

        
        PlayerLive--;
        shake.CamShake();
        if (PlayerLive == 0)
        {
            Destroy(gameObject);
            //ShowAds();
            SceneManager.LoadScene("GameOver");
            
        }
        CameraShake.instance.Shake();
    }
    void ShowAds()
    {
        if (Advertisement.IsReady(placementid))
        {
            Advertisement.Show(placementid);
        }
    }
}
