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
            //Dönmeyi hesapla
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationThisFrame);

            //Toplam dönmeyi kaydet
            totalRotation += rotationThisFrame;
        

            //Eðer 360 derece döndüyse dönmeyi durdur
            if (totalRotation >= 360)
            {
                isRotation = false; // Dönmeyi durdur
                totalRotation = 0f; // Toplam dönmeyi sýfýrla
                transform.rotation = Quaternion.Euler(0,0,0); // Dönüþ sonunda objeyi orjinal rotation deðerlerini(0,0,0) geri getir.

            }
        }


    }

    private void OnMouseDown() // Objeye mouse ile týklandý mý?
    {
        isTouched = true; //Objeye týklandý mý = evet

        if (!isRotation) // Eðer dönmüyorsa aþaðýdakileri yap
        { 
            isRotation = true; //Dönmeyi baþlat
            totalRotation = 0f;//Dönmeye sýfýrdan baþla
        }
    }
}
