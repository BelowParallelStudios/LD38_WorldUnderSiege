using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleSceneManager : MonoBehaviour {

    public Button startButton;

    void Awake()
    {
        startButton.onClick.AddListener(Action);
    }

    void Action()
    {
        SceneManager.LoadScene(1);
    }
}
