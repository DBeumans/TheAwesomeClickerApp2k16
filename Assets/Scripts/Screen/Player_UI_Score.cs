using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_UI_Score : MonoBehaviour {

    [SerializeField]
    int UI_Player_score;


    public int Public_PlayerScore;

    [SerializeField]
    Text Text_Player_Score;

    Player _player;
    int recievedScore;

    void Start()
    {
        _player = GameObject.FindObjectOfType<Player>();
        RecieveScore();
    }

    void ShowText()
    {
        Text_Player_Score.text = PlayerPrefs.GetInt("PlayerScore").ToString();

        Public_PlayerScore = UI_Player_score;
    }

    void UpdateText ()
    {
        ShowText();
    }

    public void RecieveScore()
    {
        recievedScore = _player.PlayerScore;

        UI_Player_score = recievedScore;

        UpdateText();
    }
}
