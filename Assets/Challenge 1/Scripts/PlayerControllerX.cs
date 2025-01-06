using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private float verticalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Get user input
        forwardInput = Input.GetAxis("Vertical");
        verticalInput = Input.GetAxis("Horizontal");

    }

    // FixedUpdate is called at a fixed time interval
    void FixedUpdate()
    {
        // Move the plane forward
        transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);

        // Tilt the plane up/down based on user input
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}