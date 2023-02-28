using UnityEngine;
using UnityEngine.SceneManagement;

public class MianMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitGame()
    {
        print("Exit");
        Application.Quit();
    }
}