using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{

    bool toggle = false;
    public GameObject canv;

    void Start()
    {
    }

    // Update is called once per frame


    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (toggle)
            {
                Resume();
            }
            if (!toggle)
            {
                Paused();
            }
        }
    }

    public void Paused()
    {
        toggle = true;
        Time.timeScale = 0.25f;
        canv.SetActive(true);
    }
    public void Resume()
    {
        toggle = false;
        Time.timeScale = 1;
        canv.SetActive(false);
    }
    public void loadUp(string scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1;
    }
    public void quit()
    {
        Application.Quit();
    }
}
