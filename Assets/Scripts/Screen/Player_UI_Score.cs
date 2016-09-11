using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_UI_Score : MonoBehaviour {

    //player score , player clicks.
    [SerializeField]
    Text Text_Player_Score_Clicks;
    //player score , player diamonds.
    [SerializeField]
    Text Text_Player_Score_Diamonds;
    //player score , player rubies.
    [SerializeField]
    Text Text_Player_Score_Ruby;
    //player score , player Emeralds.
    [SerializeField]
    Text Text_Player_Score_Emeralds;

    Player _player;

    int recievedScore;

    void Start()
    {
        _player = GameObject.FindObjectOfType<Player>();
        RecieveScore();
    }

    void ShowText()
    {
        Text_Player_Score_Clicks.text = PlayerPrefs.GetInt("PlayerScore_Clicks").ToString();
        Text_Player_Score_Diamonds.text = PlayerPrefs.GetInt("PlayerScore_Diamonds").ToString() + " Diamonds";
        Text_Player_Score_Ruby.text = PlayerPrefs.GetInt("PlayerScore_Rubies").ToString() + " Rubies";
        Text_Player_Score_Emeralds.text = PlayerPrefs.GetInt("PlayerScore_Emeralds").ToString() + " Emeralds";
    }

    void UpdateText ()
    {
        ShowText();
        
    }

    public void RecieveScore()
    {
        UpdateText();
    }
}
