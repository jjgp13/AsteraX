using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

//Elemento requerido en el objeto. Sino no funciona
[RequireComponent(typeof(Rigidbody))]
public class PlayerShip : MonoBehaviour
{
    //Hacer una marca en el inspector para organizacion
    [Header("Set in inspector")]
    public float speed;
    public GameObject bullet;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Move playerShip
        float xVel = CrossPlatformInputManager.GetAxis("Horizontal");
        float yVel = CrossPlatformInputManager.GetAxis("Vertical");
        Vector3 vel = new Vector3(xVel, yVel);
        
        if (vel.magnitude > 1) vel.Normalize();
        
        rb.velocity = vel * speed;

        //Shoot
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Get mouse direction
        Vector3 mPos = Input.mousePosition;
        mPos.z = -Camera.main.transform.position.z;
        Vector3 mPos3D = Camera.main.ScreenToWorldPoint(mPos);

        GameObject obj = Instantiate(bullet);
        obj.transform.position = transform.position;
        obj.transform.LookAt(mPos3D);
    }
}
