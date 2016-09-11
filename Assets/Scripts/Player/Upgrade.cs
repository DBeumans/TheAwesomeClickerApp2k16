using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {

    //tags aan buttons voor upgrade
    // public function, daarin kiest welke button onclick is, om zo upgrade te geven, als gekocht is hide button.
    SendScore _sendScore;

    int UpgradeTwo = 2;

    void Start()
    {
        _sendScore = GameObject.FindObjectOfType<SendScore>();
    }

    public void OnClickUpgrade()
    {
        CheckUpgradeButtons();
    }
    void CheckUpgradeButtons()
    {
        Debug.Log("Choosing Which button is pressed:");
        if (this.gameObject.name == "UpgradeButtonAddTwo") ;
        {
            Debug.Log("You will now obtain +2 score!");
            _sendScore.ChangeScore(UpgradeTwo);
        }

    }
}
