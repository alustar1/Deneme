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
            // Dönüþ miktarýný hesapla
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationThisFrame);

            // Toplam ne kadar döndüðünü kaydet
            totalRotation += rotationThisFrame;

            // Eðer 360 derece döndüyse, dönmeyi durdur
            if (totalRotation >= 360f)
            {
                isRotating = false;
                totalRotation = 0f; // Toplam rotasyonu sýfýrla
                transform.rotation = Quaternion.Euler(0, 0, 0); // Dönüþ sonunda objeyi orjinal rotation deðerlerini(0,0,0) geri getir.
            }
        }

        
    }



    private void OnMouseDown()
    {
        isTouched = true;

        if (!isRotating)
        {
            isRotating = true; // Dokunulduðunda dönmeye baþla
            totalRotation = 0f; // Dönmeye sýfýrdan baþla

        }
    }
}
