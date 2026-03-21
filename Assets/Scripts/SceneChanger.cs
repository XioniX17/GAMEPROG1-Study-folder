using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); 
        /*This doesn't work because in loading the Asset Package,
         * the build profile in this project doesn't match the project this asset package was in
         So going from Midterm_MainMenu scene cannot got to Midterm_Gameplay and vice versa
        
         Nvm I fixed it by adjusting the Scene Profile*/

    }
}
