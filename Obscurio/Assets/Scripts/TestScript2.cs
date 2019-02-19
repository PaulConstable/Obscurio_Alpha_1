using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TestScript2 : MonoBehaviour {


    bool isLoaded2;
	// Use this for initialization
	void Start () {
        isLoaded2 = TestScene.isLoaded;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
     
            SceneManager.UnloadSceneAsync("1.JAB");
            isLoaded2 = false;
            TestScene.isLoaded = false;
       
    }


}
