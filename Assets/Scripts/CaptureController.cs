using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptureController : MonoBehaviour {

    Texture2D ss;

    public GameObject[] allUI;
    public GameObject captureResult;
    public AudioSource audiosource;
    public GameObject saving;
    public GameObject customerPopup;
    public InputField customerName;
    public InputField customerPhone;
    public GameObject warning;

    public void PhotoShoot()
    {
        StartCoroutine(TakeScreenshotAndSave());
    }

    public void SavePhoto()
    {
        StartCoroutine(saveScreenshot());
    }

    private IEnumerator TakeScreenshotAndSave()
    {

        for (int i = 0; i < allUI.Length; i++)
        {
            allUI[i].SetActive(false);
        }

        yield return new WaitForEndOfFrame();

        audiosource.Play();
        ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();
        captureResult.GetComponent<Image>().sprite = Sprite.Create(ss, new Rect(0.0f, 0.0f, ss.width, ss.height), new Vector2(0.5f, 0.5f), 100.0f);
        captureResult.SetActive(true);

        for (int k = 0; k < allUI.Length; k++)
        {
            allUI[k].SetActive(true);
        }
    }

    private IEnumerator saveScreenshot()
    {
        if (customerName.text != "" && customerPhone.text != "")
        {
            customerPopup.SetActive(false);

            yield return new WaitForEndOfFrame();

            // Save the screenshot to Gallery/Photos pada folder DCIM->DailyCuts dengan nama CustomerName+CustomerPhone dengan format PNG
            Debug.Log("Permission result: " + NativeGallery.SaveImageToGallery(ss, "DailyCuts", "" + customerName.text + "#" + customerPhone.text + ".png"));

            saving.SetActive(true);
            yield return new WaitForSeconds(2);
            saving.SetActive(false);
            captureResult.SetActive(false);
            warning.SetActive(false);
            for (int i = 0; i < allUI.Length; i++)
            {
                allUI[i].SetActive(true);
            }
            Destroy(ss);
        }
        else {
            warning.SetActive(true);
        }
    }

    public void DeleteScreenshot()
    {
        captureResult.SetActive(false);
        if (ss != null)
        {
            Destroy(ss);
        }
    }

    public void CustomerSign()
    {
        customerPopup.SetActive(true);
    }

    public void CustomerOut()
    {
        customerPopup.SetActive(false);
    }
}