using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

    public bool boel;

    public GameObject[] listnya;
    public GameObject listjuga;
    public GameObject imagenya;
    public GameObject simpanan;

    public void simpan()
    {
        simpanan.SetActive(true);    
    }

    public void closeSimpanan()
    {
        simpanan.SetActive(false);
        imagenya.SetActive(false);
    }

    public void dlla()
    {
        imagenya.SetActive(false);
    }
    public void showlist()
    {
        boel = !boel;
    }

    private void Update()
    {
        if (boel)
        {
            for (int i = 0; i < listnya.Length; i++)
            {
                listnya[i].SetActive(true);
            }
        }else{
            for (int i = 0; i < listnya.Length; i++)
            {
                listnya[i].SetActive(false);
            }
        }
    }

    public void chooselist()
    {
        listjuga.SetActive(true);
    }

    public void capture()
    {
        imagenya.SetActive(true);
    }

    public void closecapture()
    {
        imagenya.SetActive(false);
    }

    public void backs()
    {
        SceneManager.LoadScene("MainScene");
    }
}
