using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private AudioSource killSondeffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            killSondeffect.Play();
            Destroy(collision.gameObject);
            Restart();
        }
    }
    public void Restart()
    {
        int sceneIndex=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
