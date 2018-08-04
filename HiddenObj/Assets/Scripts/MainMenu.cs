using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void Play() 
    {
        Debug.Log("Load game map.");
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Debug.Log("Quitting game");
        Application.Quit(); 
    }

}
