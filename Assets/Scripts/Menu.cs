using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject loginPanel;
    public GameObject aboutPanel;

    public void about()
    {
        aboutPanel.SetActive(true);
    }

    public void closeAbout()
    {
        aboutPanel.SetActive(false);
    }

    public void login()
    {
        loginPanel.SetActive(true);
    }

    public void closeLogin()
    {
        loginPanel.SetActive(false);
    }

    public void Simulator()
    {
        SceneManager.LoadScene("ARScene");
    }
}
