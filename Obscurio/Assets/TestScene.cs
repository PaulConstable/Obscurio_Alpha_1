using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScene : MonoBehaviour {

    public static bool isLoaded= false;
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
            SceneManager.LoadScene("1.JAB", LoadSceneMode.Additive);


        }
    }


}
