using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChanger : MonoBehaviour
{
    public GameObject kare;
    public GameObject ucgen;
    public GameObject silindir;
    public GameObject daire;
    public GameObject dikd�rtgen;
    public GameObject altigen;
    public GameObject waitingPlace;
    public GameObject firstPlace;
    public GameObject secondPlace;

    public Vector3 wPlacePosition;
    public Vector3 firstPlacePosition;
    public Vector3 secondPlacePosition;

    private void Start()
    {
        wPlacePosition = waitingPlace.transform.position;
        firstPlacePosition = firstPlace.transform.position;
        secondPlacePosition = secondPlace.transform.position;
    }

    public void positionChanger()
    {
      // �rnek  kare.transform.position =wPlacePosition;
      // Burada 1. ve 2. alana temas edenleri waitingPlace e g�nderecek
      //gerekli kodlar� yazmam�z gerekiyor


    }




}
