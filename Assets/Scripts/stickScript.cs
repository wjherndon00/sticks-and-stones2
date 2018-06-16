using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickScript : MonoBehaviour {

    public inventory inventory;

    private void Awake()
    {
        inventory = GameObject.Find("Player").GetComponent<inventory>();
    }

    // Use this for initialization
    void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        inventory.sticks++;
        Debug.Log(inventory.sticks + " sticks");
        Destroy(gameObject);
    }
}
