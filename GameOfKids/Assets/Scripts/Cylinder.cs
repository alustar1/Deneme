using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{

    private bool isTouched = false;
    public AudioSource cylinderSound;

    void Start()
    {
        cylinderSound = GetComponent<AudioSource>();

    }
    void Update()
    {
        if (isTouched)
        {
            cylinderSound.Play();
            isTouched = false;
        }
    }

    void OnMouseDown()
    {
        isTouched = true;
    }
}
