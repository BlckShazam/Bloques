using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ElementoInteractivo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    // IPointerDownHandler, IPointerUpHandler elementos necesarios para detectar eventos de tactil.


    public bool pulsado;


    //Tiene que implementarse para que IPointerDownHandler funcione.
    public void OnPointerDown(PointerEventData eventData)
    {
        pulsado = true;
    }

    //Tiene que implementarse para que IPointerUpHandler funcione.
    public void OnPointerUp(PointerEventData eventData)
    {
        pulsado = false;
    }
}
