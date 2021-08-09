using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDeathScript : MonoBehaviour {

    public GameObject gameOverCanvasUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        gameOverCanvasUI.SetActive(true);
    }
}
