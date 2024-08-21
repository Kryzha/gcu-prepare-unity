using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Transform player;
    public Text gameText;
    // Update is called once per frame
    void Update()
    {
        if(GameManager.gameHasEnded)
        { 
            gameText.text = "Game Over";
        } else gameText.text = "";
    }
}
