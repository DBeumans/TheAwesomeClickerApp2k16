using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class SendScore : EventTrigger {

    int SendScoreTo;
    Player _player;

    void Start()
    {
        SendScoreTo = 10;
        _player = GameObject.FindObjectOfType<Player>();
    }

    public void OnPointerClick()
    {
        SendPlayerScore();
    }

    void SendPlayerScore()
    {
        _player.RecievePlayerScore(SendScoreTo);
    }
}
