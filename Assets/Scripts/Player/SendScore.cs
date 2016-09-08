using UnityEngine;
using System.Collections;

public class SendScore : MonoBehaviour {

    int SendScoreTo;
    Player _player;


    void Start()
    {
        SendScoreTo = 1;
        Reference();
    }

    void Reference()
    {
        _player = GameObject.FindObjectOfType<Player>();
    }

    public void OnClick()
    {
        SendPlayerScore();
        
    }

    void SendPlayerScore()
    {
        _player.RecievePlayerScore(SendScoreTo);
        
    }

    public void ChangeScore(int score)
    {
        SendScoreTo = score;
    }
}
