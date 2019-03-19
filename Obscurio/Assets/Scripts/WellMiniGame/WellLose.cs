using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WellLose : MonoBehaviour {

    [SerializeField]
    private GameObject loseText;
    [SerializeField] private GameObject OutroScene;
    public bool wellFailed;

    public static bool youLose;




    // Use this for initialization
    void Start()
    {
        loseText.SetActive(false);
        youLose = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(wellFailed == true && Input.GetKeyDown(KeyCode.E))
        {
            //Logic for reseting the level
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("Hit Collider");
            Time.timeScale = 0;
            youLose = true;
            loseText.SetActive(true);
            OutroScene.SetActive(true);
            wellFailed = true;
        }
        
        
    }

    
    

    
}
