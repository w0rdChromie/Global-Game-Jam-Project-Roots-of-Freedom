using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNav : MonoBehaviour
{
    // Goes to the main menu
    public void toMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Goes to the tutorial
    public void toTutorial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Goes to the LV1
    public void toLV1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    // Goes to the LV2
    public void toLV2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    // Goes to the LV3
    public void toLV3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    // Goes to the LV4
    public void toLV4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    // Goes to the LV5
    public void toLV5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }



    //public void toMainMenu()
    //{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}

    public void quitButton()
    {
        Application.Quit();
    }

}
