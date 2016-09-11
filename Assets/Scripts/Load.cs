using UnityEngine;
using System.Collections;

public class Load : MonoBehaviour {

    public int Public_PlayerSavedScore_Clicks,
               Public_PlayerSavedScore_Diamonds,
               Public_PlayerSavedScore_Rubies,
               Public_PlayerSavedScore_Emeralds;

    void Awake()
    {
        LoadFile();
    }

    public void LoadFile()
    {
        //**************************************************************************************
        // LOADING || MUST BE MOVED TO OTHER SCRIPT!
        Public_PlayerSavedScore_Clicks = PlayerPrefs.GetInt("PlayerScore_Clicks");
        Public_PlayerSavedScore_Diamonds = PlayerPrefs.GetInt("PlayerScore_Diamonds");
        Public_PlayerSavedScore_Rubies = PlayerPrefs.GetInt("PlayerScore_Rubies");
        Public_PlayerSavedScore_Emeralds = PlayerPrefs.GetInt("PlayerScore_Emeralds");
    }
}
