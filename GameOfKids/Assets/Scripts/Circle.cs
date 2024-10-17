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
            //Dönüþ miktarýný hesapla
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationThisFrame);

            //Toplam ne kadar döndüðünü kaydet
            totalRotation += rotationThisFrame;

            //Eðer 360 derece döndüyse döndürmeyi durdur
            if (totalRotation >= 360f)
            {
                isRotating = false;
                totalRotation = 0f; // Toplam dönmeyi sýfýrla
                transform.rotation = Quaternion.Euler(0,0,0); // Dönüþ sonunda objeyi orjinal rotation deðerlerini(0,0,0) geri getir.
            }
        }
    }

    private void OnMouseDown()
    {
        isTouched = true;

        if (!isRotating)
        {
            isRotating = true; //Dönmüyorsa dönmeye baþla
            totalRotation = 0f; //Dönmeye sýfýrdan baþla
        }
    }
}
