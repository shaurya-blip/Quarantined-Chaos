using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScientistScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float mySpeed;
    float speedX, speedY;

    void Start()
    {

    }

    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * mySpeed;
        speedY = Input.GetAxisRaw("Vertical") * mySpeed;
        myRigidbody.velocity = new Vector2(speedX,speedY);
    }


}
