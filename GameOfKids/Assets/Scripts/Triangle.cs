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
            //Dönmeyi hesapla
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationThisFrame);

            //Toplam dönmeyi kaydet
            totalRotation += rotationThisFrame;

            //Eðer 360 derece döndüyse döndürmeyi durdur
            if (totalRotation >= 360)
            {
                isRotation = false; //Döndürmeyi durdur
                totalRotation = 0f; // Toplam Dönmeyi sýfýrla
                transform.rotation = Quaternion.Euler(0,0,0); // Dönüþ sonunda objeyi orjinal rotation deðerlerini(0,0,0) geri getir.
            }
        }
        
    }

    private void OnMouseDown()//Mouse ile týklama eventi
    {
        isTouched = true; //  Objeye týklandý mý = evet

        if (!isRotation) //Eðer dönmüyorsa aþaðýdakileri yap
        {
            isRotation = true; //Dönmeye baþla
            totalRotation = 0f; // Dönmeye sýfýrdan baþla

        }
    }



}
