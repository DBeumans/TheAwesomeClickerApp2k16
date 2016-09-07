using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int PlayerScore;
    Save _save;
    Player_UI_Score _player_ui_score;

    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("PlayerScore"));


        _save = GameObject.FindObjectOfType<Save>();
        _player_ui_score = GameObject.FindObjectOfType<Player_UI_Score>();
    }
    public void RecievePlayerScore (int score)
    {
        PlayerScore += score;
        Debug.Log(PlayerScore);
        _player_ui_score.RecieveScore();
        _save.SaveFile();
    }
}
