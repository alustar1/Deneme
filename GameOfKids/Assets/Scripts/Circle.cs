using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    private bool isRotating = false;
    private float totalRotation = 0f;
    private float rotationSpeed = 270f;
    
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

        if (isRotating)
        {
            //D�n�� miktar�n� hesapla
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationThisFrame);

            //Toplam ne kadar d�nd���n� kaydet
            totalRotation += rotationThisFrame;

            //E�er 360 derece d�nd�yse d�nd�rmeyi durdur
            if (totalRotation >= 360f)
            {
                isRotating = false;
                totalRotation = 0f; // Toplam d�nmeyi s�f�rla
                transform.rotation = Quaternion.Euler(0,0,0); // D�n�� sonunda objeyi orjinal rotation de�erlerini(0,0,0) geri getir.
            }
        }
    }

    private void OnMouseDown()
    {
        isTouched = true;

        if (!isRotating)
        {
            isRotating = true; //D�nm�yorsa d�nmeye ba�la
            totalRotation = 0f; //D�nmeye s�f�rdan ba�la
        }
    }
}
