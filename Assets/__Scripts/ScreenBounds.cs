using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour {

    //cuando el algun objeto de juego salga de la pantalla.
    private void OnTriggerExit(Collider other)
    {
        //Si es la nave o una bala, el objeto tiene que aparecer del otro lado 
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Bullet")
        {
            Vector3 exitPos = other.transform.position;
            Vector3 entryPos = exitPos * -1;
            other.transform.position = entryPos;
        }
    }
}
