using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour {

    public int sticks = 0;
    public int stones = 0;
    public Text inventoyText;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update() {
        inventoyText.text = "sticks: " + sticks.ToString() + ". stones: " + stones.ToString() + " .";
	}
}
