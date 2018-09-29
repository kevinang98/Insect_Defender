using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool GameIsOver;

    public Transform canvas;

    void Start()
    {
        GameIsOver = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (GameIsOver)
            return;

        if (PlayerStats.Lives <= 0)
        {
            EndGame(); 
        }
	}

    void EndGame()
    {
        GameIsOver = true;
        canvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}