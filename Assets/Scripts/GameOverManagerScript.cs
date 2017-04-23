using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverManagerScript : MonoBehaviour {

    public Text finalScoreText;
    public Button rePlayButton;

    void Awake()
    {
        finalScoreText.text = "Final Score: " + GameManager.killCount;
        rePlayButton.onClick.AddListener(Action);
    }
	
    void Action()
    {
        GameManager.killCount = 0;
        GameManager.health = 3;
        GameManager.isRunning = true;
        SceneManager.LoadScene(1);
    }
	
}
