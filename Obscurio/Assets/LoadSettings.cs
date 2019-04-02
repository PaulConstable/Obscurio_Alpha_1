using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSettings : MonoBehaviour {


    [SerializeField] public GameObject SettingMenu;
    [SerializeField] public GameObject eButton;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    private void OnTriggerStay2D(Collider2D collision)
    {
        eButton.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            SettingMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        eButton.SetActive(false);
    }

    public void exitMenu()
    {
        SettingMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
