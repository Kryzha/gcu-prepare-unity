using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    private bool dKey = false;
    private bool aKey = false;

    void Update()
    {
        if(Input.GetKey("d")) // If the player is pressing the "d" key
        {
            dKey = true;
        } else dKey = false;

        if(Input.GetKey("a")) // If the player is pressing the "a" key
        {
            aKey = true;
        } else aKey = false;
    }

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        if(PlayerCollision.canMove){
            rb.AddForce(0, 0, forwardForce * Time.deltaTime ); // Add a forward force

            if(dKey) //check if the player is moving right
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);// Add a force to the right
            }

            if(aKey) //check if the player is moving left
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);// Add a force to the left
            }

            if(rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        } 
    }
}