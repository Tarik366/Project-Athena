using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public GameObject DialogPanel;
    public Text DialogText;
    public string dialog;
    public bool dialogActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown("e"))
        {
            DialogPanel.SetActive(true);
            DialogText.text = dialog;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        DialogPanel.SetActive(false);
    }
}
