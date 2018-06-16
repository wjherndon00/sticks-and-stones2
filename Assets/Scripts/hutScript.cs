using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hutScript : MonoBehaviour {

    public playerController pc;

	// Use this for initialization
	void Start () {
        pc = GameObject.Find("Player").GetComponent<playerController>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        pc.ChangePlayerOrderInLayer(-1);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        pc.ChangePlayerOrderInLayer(-1);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pc.ChangePlayerOrderInLayer(1);
    }

}
