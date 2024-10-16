using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private bool isTouched = false;
    public AudioSource squareSound;
    public Transform rotations;
    

    
    void Start()
    {
        squareSound = GetComponent<AudioSource>();   
        rotations = GetComponent<Transform>();
       
    }

    
    void Update()
    {
        if (isTouched)
            {
            rotations.Rotate(0, 0, 60);
            squareSound.Play();
            isTouched = false;
            }
    }

    private void OnMouseDown()
    {
        isTouched = true;
    }

    

    

  
}
