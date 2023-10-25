using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

   

    public void Solo()
    {
        SceneManager.LoadScene(2);
    }

    public void Explanation()
    {
        SceneManager.LoadScene(8);
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

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Closed Application");
    }
}