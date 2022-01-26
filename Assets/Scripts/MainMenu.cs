using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    SceneManager loader;

    public void load()
    {
        SceneManager.LoadScene("Level One");
    }
    public void quit()
    {
        Application.Quit();
    }
}
