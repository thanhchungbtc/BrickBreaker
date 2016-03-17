using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    public void PlayGame() {
        SceneManager.LoadScene("Gameplay");
    }

    public void About() {        
        SceneManager.LoadScene("About");
    }
    
    public void BackToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
