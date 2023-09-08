using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class ArrowId : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);
            }
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Activator")
        {
            canBePressed = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
        }
    }

}
