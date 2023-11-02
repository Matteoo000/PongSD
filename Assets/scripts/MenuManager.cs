using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

   
// if buttons are pressed in the game it will load the according scene/mode
    public void Solo()
    {
        SceneManager.LoadScene(2);
    }

    public void Explanation()
    {
        SceneManager.LoadScene(6);
    }

    public void Versus()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Headache()
    {
        SceneManager.LoadScene(3);
    }
    // closes of the game when Quit button pressed (only works in build)
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Closed Application");
    }
}