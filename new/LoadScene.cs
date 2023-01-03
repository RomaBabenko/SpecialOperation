using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Kherson()
    {
        SceneManager.LoadScene("Kherson");
    }

    public void Azov()
    {
        SceneManager.LoadScene("Azov");
    }

    public void Bucha()
    {
        SceneManager.LoadScene("Bucha");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
