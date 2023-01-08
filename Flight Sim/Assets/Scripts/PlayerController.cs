using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public float speed = 10f;
    Vector3 movement;
    Vector3 throttle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("YokeX");
        movement.y = Input.GetAxis("Rudders");
        movement.z = Input.GetAxis("YokeY");
        //throttle = 1;
        throttle.x = Input.GetAxis("Throttle");
    }
    void FixedUpdate()
    {
        rb.AddForce(throttle * speed);
        transform.Rotate(movement);
    }
}