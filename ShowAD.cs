using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ShowAD : MonoBehaviour
{

    public void ButtonClickAd()
    {
        if(Advertisement.IsReady("rewardedVideo"))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);
            this.transform.parent.gameObject.SetActive(false);
        }

    }
    public void HandleShowResult(ShowResult result)
    {
        switch(result)
        {
            case ShowResult.Finished:
                PlayerInfor.Diamond += 10;
                break;

            case ShowResult.Skipped:
                break;

            case ShowResult.Failed:
                break;

        }
    }

}
