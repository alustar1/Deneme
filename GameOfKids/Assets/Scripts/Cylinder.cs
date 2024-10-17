using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    private bool isRotating = false;
    private float totalRotation = 0f;
    public float rotationSpeed = 270f;

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


        if (isRotating)
        {
            // D�n�� miktar�n� hesapla
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationThisFrame);

            // Toplam ne kadar d�nd���n� kaydet
            totalRotation += rotationThisFrame;

            // E�er 360 derece d�nd�yse, d�nmeyi durdur
            if (totalRotation >= 360f)
            {
                isRotating = false;
                totalRotation = 0f; // Toplam rotasyonu s�f�rla
                transform.rotation = Quaternion.Euler(0, 0, 0); // D�n�� sonunda objeyi orjinal rotation de�erlerini(0,0,0) geri getir.
            }
        }

        
    }



    private void OnMouseDown()
    {
        isTouched = true;

        if (!isRotating)
        {
            isRotating = true; // Dokunuldu�unda d�nmeye ba�la
            totalRotation = 0f; // D�nmeye s�f�rdan ba�la

        }
    }
}
