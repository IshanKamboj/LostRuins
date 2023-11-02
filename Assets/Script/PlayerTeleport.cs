using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject currentTeleporter;
    [SerializeField] private AudioSource teleportsoundeffect;
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.E))
       {
        if(currentTeleporter != null)
        {
            transform.position=currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
            teleportsoundeffect.Play();
        }
       }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Teleporter"))
        {
            currentTeleporter=collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Teleporter"))
        {
            currentTeleporter=null;
        }
    }
}
