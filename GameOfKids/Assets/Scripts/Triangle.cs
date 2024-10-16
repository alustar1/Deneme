using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    private bool isTouched = false;
    public AudioSource triangleSound;
    
    void Start()
    {
        triangleSound = GetComponent<AudioSource>();   
    }

    
    void Update()
    {
        if (isTouched)
        {
            triangleSound.Play();
            isTouched = false;
        }
        
    }

    private void OnMouseDown()
    {
        isTouched = true;
    }



}
