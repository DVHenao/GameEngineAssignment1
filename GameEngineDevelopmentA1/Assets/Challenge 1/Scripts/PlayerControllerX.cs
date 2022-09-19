using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxisRaw("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys


        Debug.Log(verticalInput);

        if (verticalInput == -1)
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        else if (verticalInput == 1)
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
    }
}
