using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public static bool canMove = true;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            canMove = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}
