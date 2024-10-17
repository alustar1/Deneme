using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonrakiAsamaBTN : MonoBehaviour
{

    public GameObject kare;
    public GameObject ucgen;
    public GameObject silindir;
    public GameObject daire;
    public GameObject dikdörtgen;
    public GameObject altigen;
    public GameObject waitingPlace;

    private bool isClick = false;
    private Vector3 wPlacePosition;




    void Start()
    {
        wPlacePosition = waitingPlace.transform.position; 
    }

    
    void Update()
    {

        if (isClick)
        {
            kare.transform.Translate(wPlacePosition);
            isClick = false;

        }


    }

    void OnButtonClick()
    {
        if (!isClick)
        {
            isClick = true;
        }
    }
}
