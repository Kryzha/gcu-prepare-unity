using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        if(GameManager.gameHasEnded == false)
        {
        gameManager.CompleteLevel();
        FindObjectOfType<AudioManager>().Play("LevelComplete");
        }

    }
}
