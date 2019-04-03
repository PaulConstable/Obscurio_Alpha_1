using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StoryPagesScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadLevel1()
    {
        SceneManager.LoadScene("1.JAB");
    }
    public void loadLevel2()
    {
        SceneManager.LoadScene("2.HAG");
    }
}
// well game
// level 1
//level 2