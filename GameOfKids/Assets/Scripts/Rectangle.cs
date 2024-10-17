using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{
    private bool isRotation = false;
    private float totalRotation = 0f;
    private float rotationSpeed = 270f;

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

        if (isRotation)
        {
            //D�nmeyi hesapla
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationThisFrame);

            //Toplam d�nmeyi kaydet
            totalRotation += rotationThisFrame;
        

            //E�er 360 derece d�nd�yse d�nmeyi durdur
            if (totalRotation >= 360)
            {
                isRotation = false; // D�nmeyi durdur
                totalRotation = 0f; // Toplam d�nmeyi s�f�rla
                transform.rotation = Quaternion.Euler(0,0,0); // D�n�� sonunda objeyi orjinal rotation de�erlerini(0,0,0) geri getir.

            }
        }


    }

    private void OnMouseDown() // Objeye mouse ile t�kland� m�?
    {
        isTouched = true; //Objeye t�kland� m� = evet

        if (!isRotation) // E�er d�nm�yorsa a�a��dakileri yap
        { 
            isRotation = true; //D�nmeyi ba�lat
            totalRotation = 0f;//D�nmeye s�f�rdan ba�la
        }
    }
}
