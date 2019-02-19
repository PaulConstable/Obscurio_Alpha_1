using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScene : MonoBehaviour {

    public static bool isLoaded= false;
    public static GameObject test;
    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isLoaded == false)
        {
            isLoaded = true;
            SceneManager.LoadScene("Puzzle-Game", LoadSceneMode.Additive);
            Destroy(gameObject);


        }
    }


}
