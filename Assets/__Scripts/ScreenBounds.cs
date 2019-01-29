using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour {

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Bullet")
        {
            Vector3 exitPos = other.transform.position;
            Vector3 entryPos = exitPos * -1;
            other.transform.position = entryPos;
        }
    }
}
