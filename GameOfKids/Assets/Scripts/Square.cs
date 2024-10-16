using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private bool isTouched = false;
    public AudioSource squareSound;

    
    void Start()
    {
        squareSound = GetComponent<AudioSource>();   
    }

    
    void Update()
    {
        if (isTouched)
            { 
            squareSound.Play();
            isTouched = false;
            }
    }

    private void OnMouseDown()
    {
        isTouched = true;
    }

    



  
}
