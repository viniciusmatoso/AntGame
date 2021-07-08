using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    #if UNITY_IOS
    private string gameId = "4183842";
    #elif UNITY_ANDROID
    private string gameId = "1486550";
    #endif
    bool testMode = true;

    public static bool mostrar = false;
    void Start()
    {
        // Initialize the Ads service:
        Advertisement.Initialize(gameId, testMode);
    }

    void Update()
    {

        if (mostrar)
        {
            ShowInterstitialAd();
        }

    }

    public void ShowInterstitialAd()
    {
        
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
            // Replace mySurfacingId with the ID of the placements you wish to display as shown in your Unity Dashboard.
        }
        else
        {
            Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
        }
        mostrar = false;
        
    }
}
