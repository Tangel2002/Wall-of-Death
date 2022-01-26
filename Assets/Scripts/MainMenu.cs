using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    SceneManager loader;

    public void load(string level)
    {
        SceneManager.LoadScene(level);
        Time.timeScale = 1;
    }
    public void quit()
    {
        Application.Quit();
    }
}
