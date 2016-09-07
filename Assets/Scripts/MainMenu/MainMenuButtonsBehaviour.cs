using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuButtonsBehaviour : MonoBehaviour {
    
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
