using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VitoriaScript : MonoBehaviour {

    public GameObject telaVitoria;

    public string newLevel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        telaVitoria.SetActive(true);

        SceneManager.LoadScene(newLevel); // gerando apenas fase 2, buga na fase 2
    }
}
