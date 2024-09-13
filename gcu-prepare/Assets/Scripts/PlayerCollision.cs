using UnityEngine;
using UnityEngine.SceneManagement;
using EZCameraShake;
public class PlayerCollision : MonoBehaviour
{
    public GameObject destroyedVersion;
    public PlayerMovement movement;
    public static bool canMove = true;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            canMove = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<AudioManager>().Play("Death");
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
        }
    }
}
