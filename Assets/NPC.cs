using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public GameObject Panel;
    public Text DialougeText;
    private int index;

    public float wordSpeed;
    public bool playerIsClose;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e") && playerIsClose)
        {
                Panel.SetActive(true);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }
}
