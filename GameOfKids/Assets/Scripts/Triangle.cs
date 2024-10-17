using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    private bool isRotation = false;
    private float totalRotation = 0f;
    private float rotationSpeed = 270f;

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

        if (isRotation)
        {
            //D�nmeyi hesapla
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationThisFrame);

            //Toplam d�nmeyi kaydet
            totalRotation += rotationThisFrame;

            //E�er 360 derece d�nd�yse d�nd�rmeyi durdur
            if (totalRotation >= 360)
            {
                isRotation = false; //D�nd�rmeyi durdur
                totalRotation = 0f; // Toplam D�nmeyi s�f�rla
                transform.rotation = Quaternion.Euler(0,0,0); // D�n�� sonunda objeyi orjinal rotation de�erlerini(0,0,0) geri getir.
            }
        }
        
    }

    private void OnMouseDown()//Mouse ile t�klama eventi
    {
        isTouched = true; //  Objeye t�kland� m� = evet

        if (!isRotation) //E�er d�nm�yorsa a�a��dakileri yap
        {
            isRotation = true; //D�nmeye ba�la
            totalRotation = 0f; // D�nmeye s�f�rdan ba�la

        }
    }



}
