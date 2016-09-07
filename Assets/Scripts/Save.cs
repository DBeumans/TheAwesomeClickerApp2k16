using UnityEngine;
using System.Collections;

public class Save : MonoBehaviour {

    Player _player;

    int PlayerSavedScore;
    int IncommingPlayerScore;

    void Start()
    {
        _player = GameObject.FindObjectOfType<Player>();
    }

    public void SaveFile()
    {
        PlayerSavedScore = PlayerPrefs.GetInt("PlayerScore");
        
        IncommingPlayerScore = _player.PlayerScore;
        
        PlayerSavedScore += IncommingPlayerScore;
        Debug.Log("PlayerSavedScore: " +PlayerSavedScore);

        PlayerPrefs.SetInt("PlayerScore", PlayerSavedScore);

        PlayerPrefs.Save();
       
    }

}
