using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a forward force
    
        if(Input.GetKey("d")) // If the player is pressing the "d" key
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0); // Add a force to right
        }

        if(Input.GetKey("a")) // If the player is pressing the "s" key
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0); // Add a force to left
        }
    }
}
