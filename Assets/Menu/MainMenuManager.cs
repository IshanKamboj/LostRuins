using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // [SerializeField] private AudioSource clicksoundeffect;
    public GameObject instructionPanel;
    private void Start()
    {
        instructionPanel.SetActive(false);
        // Invoke(StartGame,2f);
    }

     private void Update()
     {
        if(Input.GetKey(KeyCode.I)){
            instructionPanel.SetActive(false);
        }
     }

    public void ShowInstructions()
    {
        // clicksoundeffect.Play();
        instructionPanel.SetActive(true);
    }
   public void StartGame()
   {
    // clicksoundeffect.Play();
    SceneManager.LoadScene(1);
   }
   public void Quitgame()
   {
    // clicksoundeffect.Play();
    Application.Quit();
    Debug.Log("Quit");
   }
}
