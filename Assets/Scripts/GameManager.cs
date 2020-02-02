using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool gameOver;
    
    public static GameManager instance;
    private int score;
    
    void Awake () {
		if (instance == null) {
			instance = this;
		}
        DontDestroyOnLoad(this.gameObject);
	}

    public void GameOver()
    {
        gameOver = true;
        SceneManager.LoadScene ("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        gameOver = false;
        SceneManager.LoadScene("Main");
    }
}
