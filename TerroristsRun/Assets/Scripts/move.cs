using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public float speed;

    private Rigidbody rb;
    private Vector3 movement;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movement = rb.transform.position;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement = new Vector3(moveHorizontal + speed, 0.0f, moveVertical);
            rb.AddForce(movement);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement = new Vector3(moveHorizontal - speed, 0.0f, moveVertical);
            rb.AddForce(movement);
        }
    }
}
