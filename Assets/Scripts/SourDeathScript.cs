using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourDeathScript : MonoBehaviour {

    public GameObject gameOverUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        gameOverUI.SetActive(true);
    }
}
