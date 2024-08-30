using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        FindObjectOfType<AudioManager>().Play("LevelComplete");

    }
}
