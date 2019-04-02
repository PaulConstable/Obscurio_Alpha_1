using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSettings : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    private void OnTriggerEnter2D(Collider2D collision)
    {
            SceneManager.LoadScene("SettingMenu", LoadSceneMode.Additive);
        Time.timeScale = 0; 
    }
}
