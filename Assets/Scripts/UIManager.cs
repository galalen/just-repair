using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text counterText;
    public Text lifeText;
    public static UIManager instance;
    private int score;

    void Awake () {
		if (instance == null) {
			instance = this;
		}
        DontDestroyOnLoad(this.gameObject);
        score = 0;
	}

    public void UpdateScoreText()
    {
        score += 1;
        counterText.text = score + "";
    }

     public void Log(string text)
    {
        counterText.text = text;
    }

    public void UpdateLifeText(int life)
    {
        lifeText.text = "Lifes: " + life;
    }

}
