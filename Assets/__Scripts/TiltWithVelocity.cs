using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltWithVelocity : MonoBehaviour {

    [Tooltip("Maximo grado de rotacion de la nave")]
    public int maxTilt;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        rb.rotation = Quaternion.Euler(rb.velocity.y * maxTilt, rb.velocity.x * -maxTilt, 0f);
	}
}
