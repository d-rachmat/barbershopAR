using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

    public bool boel;
    
    public GameObject listjuga;
    public GameObject captureresult;
    public GameObject simpanan;
    public Animator anima;

    public GameObject[] listHair;
    public GameObject[] listObjectHair;


    public void showlist()
    {
        if (!boel)
        {
            anima.SetTrigger("in");
            boel = true;
        }
        else {
            anima.SetTrigger("out");
            boel = false;
        }
      
    }

    public void chooselist(GameObject thisHair)
    {
        for (int i = 0; i < listHair.Length; i++)
        {
            listHair[i].SetActive(false);
        }

        listjuga.SetActive(true);
        thisHair.SetActive(true);
    }    

    public void sceneController()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void chooseHair(GameObject GO)
    {
        for (int i = 0; i < listObjectHair.Length; i++)
        {
            listObjectHair[i].SetActive(false);
        }
        GO.SetActive(true);
    }

}
