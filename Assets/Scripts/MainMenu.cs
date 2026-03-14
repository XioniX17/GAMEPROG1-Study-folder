using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        Debug.Log("New Game Starts!");
        SceneManager.LoadScene("GameplayScene");
    }

    public void Return2Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
