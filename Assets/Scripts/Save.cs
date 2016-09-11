using UnityEngine;
using System.Collections;

public class Save : MonoBehaviour {

    Player _player;

    int PlayerSavedScore_Clicks,
        PlayerSavedScore_Diamonds,
        PlayerSavedScore_Rubies,
        PlayerSavedScore_Emeralds;

    int IncommingPlayerScore_Clicks,
        IncommingPlayerScore_Diamonds,
        IncommingPlayerScore_Rubies,
        IncommingPlayerScore_Emeralds;

    void Start()
    {
        _player = GameObject.FindObjectOfType<Player>();
    }

    public void SaveFile()
    {
        // Getting score from the Player Class.
        IncommingPlayerScore_Clicks = _player.PlayerScore_Clicks;
        IncommingPlayerScore_Diamonds = _player.PlayerScore_Diamonds;
        IncommingPlayerScore_Rubies = _player.PlayerScore_Rubies;
        IncommingPlayerScore_Emeralds = _player.PlayerScore_Emeralds;

        // Saving The Incomming score to a variable thats going to be used to save for PlayerPrefs.
        PlayerSavedScore_Clicks = IncommingPlayerScore_Clicks;
        PlayerSavedScore_Diamonds = IncommingPlayerScore_Diamonds;
        PlayerSavedScore_Rubies = IncommingPlayerScore_Rubies;
        PlayerSavedScore_Emeralds = IncommingPlayerScore_Emeralds;
        //**************************************************************************************
        // DEBUG
        Debug.Log("PlayerSavedScore_Clicks: " + PlayerSavedScore_Clicks);
        Debug.Log("PlayerSavedScore_Diamonds: " + PlayerSavedScore_Diamonds);
        Debug.Log("PlayerSavedScore_Rubies: " + PlayerSavedScore_Rubies);
        Debug.Log("PlayerSavedScore_Emeralds: " + PlayerSavedScore_Emeralds);
        //**************************************************************************************
        // SAVING
        PlayerPrefs.SetInt("PlayerScore_Clicks", PlayerSavedScore_Clicks);// saving player clicks
        PlayerPrefs.SetInt("PlayerScore_Diamonds", PlayerSavedScore_Diamonds);// saving player diamonds
        PlayerPrefs.SetInt("PlayerScore_Rubies", PlayerSavedScore_Rubies);// saving player rubies
        PlayerPrefs.SetInt("PlayerScore_Emeralds", PlayerSavedScore_Emeralds);// saving player emeralds

        PlayerPrefs.Save();
       
    }

}
