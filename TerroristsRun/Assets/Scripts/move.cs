using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public float speed = 120;
    public float jump = 25;
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
            rb.AddForce(new Vector3(speed, 0, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector3(-speed, 0, 0));
        }

        if (Input.GetKey(KeyCode.Space) && rb.velocity.y < 0.5f && rb.position.y < 15)
        {
            rb.AddForce(new Vector3(0, jump, 0),ForceMode.Impulse);
            Ahmed.anim.SetTrigger("Jump");

        }
    }
}
