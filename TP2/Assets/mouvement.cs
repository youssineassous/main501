using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    public float jumpForce = 5f;
    public float speed = 1f; 
    public float speedMultiplier = 3f; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
{
float moveSpeed = speed;

if (Input.GetKey(KeyCode.LeftShift))
    {
        moveSpeed *= speedMultiplier; 
    }

if (Input.GetKey(KeyCode.DownArrow))
{
transform.Translate(Vector3.forward * moveSpeed);
}
if (Input.GetKey(KeyCode.UpArrow))
{
transform.Translate(Vector3.back * moveSpeed);
}
if (Input.GetKey(KeyCode.LeftArrow))
{
transform.Rotate(Vector3.up, -2);
}
if (Input.GetKey(KeyCode.RightArrow))
{
transform.Rotate(Vector3.up, 2);
}

if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
}

private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
