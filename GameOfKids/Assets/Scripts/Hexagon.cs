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
            //Dönüþ miktarýný hesapla
            float rotationThisFrame = rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationThisFrame);

            //Toplam ne kadar döndüðünü kaydet
            totalRotation += rotationThisFrame;

            //Eðer 360 derece döndüyse döndürmeyi durdur
            if (totalRotation >= 360f)
            {
                isRotation = false; // dönmeyi durdur
                totalRotation = 0f; // toplam dönmeyi sýfýrla
                transform.rotation = Quaternion.Euler(0,0,0); // Dönüþ sonunda objeyi orjinal rotation deðerlerini(0,0,0) geri getir.
            }
            
        }
    }
    private void OnMouseDown()
    {
        isTouched = true;

        if (!isRotation) //Dönmüyorsa aþaðýdakileri yap
        {
            isRotation = true; // Dönmeyi baþlat
            totalRotation = 0f; //Dönmeyi sýfýrdan baþlat
        }
    }
}
