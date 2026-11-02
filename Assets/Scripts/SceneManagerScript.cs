using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{

    // Load Main Gameplay
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    //Ends Program
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quiting Game");
    }
}
