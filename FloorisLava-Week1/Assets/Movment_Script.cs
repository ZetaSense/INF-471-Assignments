using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movment_Script : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody rb;
    public int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        print ("hello world");
    }

    void OnMove(InputValue moveval)
    {
        movement = moveval.Get<Vector2>();
        float movex = movement.x;
        float movey = movement.y;
        Vector3 movement3 = new Vector3(movex, 0.0f, movey);
        rb.AddForce(movement3*speed);
    }
}
