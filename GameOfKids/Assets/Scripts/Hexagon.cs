using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    private bool isRotation = false;
    private float totalRotation = 0f;
    private float rotationSpeed = 270f;
    
    
    
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

        if (isRotation)
        {
            //D�n�� miktar�n� hesapla
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationThisFrame);

            //Toplam ne kadar d�nd���n� kaydet
            totalRotation += rotationThisFrame;

            //E�er 360 derece d�nd�yse d�nd�rmeyi durdur
            if (totalRotation >= 360f)
            {
                isRotation = false; // d�nmeyi durdur
                totalRotation = 0f; // toplam d�nmeyi s�f�rla
                transform.rotation = Quaternion.Euler(0,0,0); // D�n�� sonunda objeyi orjinal rotation de�erlerini(0,0,0) geri getir.
            }
            
        }
    }
    private void OnMouseDown()
    {
        isTouched = true;

        if (!isRotation) //D�nm�yorsa a�a��dakileri yap
        {
            isRotation = true; // D�nmeyi ba�lat
            totalRotation = 0f; //D�nmeyi s�f�rdan ba�lat
        }
    }
}
