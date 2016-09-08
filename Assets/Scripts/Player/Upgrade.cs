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

    public void OnClick()
    {
        CheckUpgradeButtons();
    }
    void CheckUpgradeButtons()
    {
        if(gameObject.name == "UpgradeButtonAddTwo")
        {
            // increase coins
            // hide button
            Debug.Log("Changed Score, you gain +2.!");
            _sendScore.ChangeScore(UpgradeTwo);


        }
    }
}
