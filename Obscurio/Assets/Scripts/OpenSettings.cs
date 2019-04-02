using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour {

    [SerializeField] GameObject SettingMenu;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SettingMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void closeMenu()
    {
        SettingMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
