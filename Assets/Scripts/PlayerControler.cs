using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float gravity = 9.8f;
    public GameObject player;
    public float rotationSpeed = 360f;
    public float movementSpeed = 20f;
    public float acceleration = 50f;
    public float fuel = 100f;
    private Rigidbody2D rigid; //default value null



    // Use this for initialization
    // <acess-specifier> <return-type> <function-name>
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {

        Movement();
        Rotation();


    }

    void Movement()
    {
        if (fuel > 0)
        {
            if (Input.GetKey("w"))
            {
                rigid.AddForce(transform.right * movementSpeed);
                fuel--;
            }
        }
    }

    void Rotation()
    {
        float inputH = Input.GetAxis("Horizontal");
        transform.rotation *= Quaternion.AngleAxis(inputH * rotationSpeed * Time.deltaTime, -Vector3.forward);
    }



    // Update is called once per frame
    void LateUpdate()
    {
        Physics2D.gravity = new Vector2(0, -1);

    }
}
