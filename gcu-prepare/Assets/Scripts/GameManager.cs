using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delayTime = 2f;

    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", delayTime);
        }
    }

        void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerCollision.canMove = true;
    }

}
