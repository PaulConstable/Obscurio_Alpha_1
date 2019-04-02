using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SettingPage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void exitMenu()
    {
        SceneManager.UnloadSceneAsync("SettingMenu");
        Time.timeScale = 1;
    }
}
