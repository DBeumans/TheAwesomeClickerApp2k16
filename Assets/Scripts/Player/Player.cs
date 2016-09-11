using UnityEngine;
using System.Collections;

public class Player : Load {

    Save _save;
    Player_UI_Score _player_ui_score;

    public int PlayerScore_Clicks,
               PlayerScore_Diamonds,
               PlayerScore_Rubies,
               PlayerScore_Emeralds;

    void Start()
    {
        LoadPlayerScore();

        _save = GameObject.FindObjectOfType<Save>();
        _player_ui_score = GameObject.FindObjectOfType<Player_UI_Score>();
    }

    void LoadPlayerScore()
    {
        PlayerScore_Clicks = Public_PlayerSavedScore_Clicks;
        PlayerScore_Diamonds = Public_PlayerSavedScore_Diamonds;
        PlayerScore_Rubies = Public_PlayerSavedScore_Rubies;
        PlayerScore_Emeralds = Public_PlayerSavedScore_Emeralds;
    }

    public void RecievePlayerScore (int score)
    {
        PlayerScore_Clicks += score;
        
        _save.SaveFile();
        _player_ui_score.RecieveScore();
    }

    void Update()
    {
        CheckPlayerScore();
    }
    void CheckPlayerScore()
    {
        //checking if the player clicked 100 times, if so add one diamond.
        if (PlayerScore_Clicks > 99)
        {
            PlayerScore_Diamonds++;
            PlayerScore_Clicks = 0;
        }
        // if player got 100+ diamonds, add one ruby
        if (PlayerScore_Diamonds > 99)
        {
            PlayerScore_Rubies++;
            PlayerScore_Diamonds = 0;
        }
        // if player got 100+ rubies, add one emerald
        if (PlayerScore_Rubies > 99)
        {
            PlayerScore_Emeralds++;
            PlayerScore_Rubies = 0;
        }
    }

}
