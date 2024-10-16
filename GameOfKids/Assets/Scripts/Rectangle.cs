using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{
    public bool isTouched = false;
    public AudioSource rectangleSound;
    void Start()
    {
        rectangleSound = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(isTouched)
        {
            rectangleSound.Play();
            isTouched = false;
        }
    }

    private void OnMouseDown()
    {
        isTouched = true;
    }
}
