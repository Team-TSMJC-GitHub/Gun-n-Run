using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void selectScene()
    {
        switch(this.gameObject.name)
        {
            case "StartButton":
                SceneManager.LoadScene("Scene 1");
                
                break;
            case "ShopButton":
                SceneManager.LoadScene("Scene 2 Shop");
                break;
            case "HighscoreButton":
                SceneManager.LoadScene("Scene 3 Highscore");
                break;
           
        }
    }
}
