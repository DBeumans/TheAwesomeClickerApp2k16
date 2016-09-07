using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    int PlayerScore;

    void Start ()
    {
        
    }

    public void RecievePlayerScore (int score)
    {
        PlayerScore = score;
        Debug.Log(PlayerScore);
    }
}
