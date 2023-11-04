using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviours : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        // clicksoundeffect.Play();
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    public void Quitgame()
    {
        // clicksoundeffect.Play();
        Application.Quit();
        Debug.Log("Quit");
    }
}
