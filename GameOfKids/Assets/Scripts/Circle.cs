using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    private bool isTouched = false;
    public AudioSource circleSound;
    void Start()
    {
        circleSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (isTouched) 
        {
            circleSound.Play();
            isTouched = false;
        }
    }

    private void OnMouseDown()
    {
        isTouched = true;
    }
}
