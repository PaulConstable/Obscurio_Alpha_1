﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour {

    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;

    BeanStalkTrigger myBeanStalkTrigger;


	// Use this for initialization
	void Start () {
        winText.SetActive(false);
        youWin = false;
        myBeanStalkTrigger = FindObjectOfType<BeanStalkTrigger>();
	}


    // Update is called once per frame
    private void Update()
    {
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0 &&
            pictures[6].rotation.z == 0 &&
            pictures[7].rotation.z == 0 &&
            pictures[8].rotation.z == 0 &&
            pictures[9].rotation.z == 0 &&
            pictures[10].rotation.z == 0 &&
            pictures[11].rotation.z == 0 &&
            pictures[12].rotation.z == 0 &&
            pictures[13].rotation.z == 0 &&
            pictures[14].rotation.z == 0 &&
            pictures[15].rotation.z == 0 )
        {
            youWin = true;
            winText.SetActive(true);
            myBeanStalkTrigger.SetBeanState3();
            SceneManager.UnloadSceneAsync("Puzzle-Game");
        } 
            
                
                
                
                
                
                }
	}

