using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Panda")
        {
            Destroy(gameObject);
            other.GetComponent<PlayerScript>().moedas++;
        }
    }
}
