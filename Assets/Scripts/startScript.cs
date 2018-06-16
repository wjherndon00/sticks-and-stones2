using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void startGame()
    {
        Debug.Log("starting game");
        SceneManager.LoadScene(1);
    }

}
