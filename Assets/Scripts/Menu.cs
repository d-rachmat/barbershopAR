using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject login;
    public GameObject about;

    public void abouts()
    {
        about.SetActive(true);
    }

    public void closeAbout()
    {
        about.SetActive(false);
    }

    public void logins()
    {
        login.SetActive(true);
    }

    public void closeLogin()
    {
        login.SetActive(false);
    }

    public void Simulator()
    {
        SceneManager.LoadScene("faceMask");
    }
}
