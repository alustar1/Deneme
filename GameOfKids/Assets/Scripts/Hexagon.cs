using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public bool isTouched = false;
    public AudioSource hexagonSound;
   
    void Start()
    {
        hexagonSound = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(isTouched)
        {
            hexagonSound.Play();
            isTouched = false;
        }
    }
    private void OnMouseDown()
    {
        isTouched = true;
    }
}
