﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BeanSpawn : MonoBehaviour
{

    public GameObject BlackBean;
    public float spawnTimeBlackBean;
    public GameObject RedBean;
    public float spawnTimeRedBean;
    public GameObject GoldBean;
    public float spawnTimeGoldBean;
    public GameObject[] medals;
    public GameObject outro;


    // text
    public Text beanPlayerScore;
    float timeLeft = 30f;
    private float playerBeanScore = 0;

    BeanStalkTrigger myBeanStalkTrigger;
    BeanGuyTrigger myBeanGuyTrigger;
    
    void Start()
    {

        myBeanStalkTrigger = FindObjectOfType<BeanStalkTrigger>();
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();

        InvokeRepeating("BlackBeanInstance", spawnTimeBlackBean, spawnTimeBlackBean);
  
        InvokeRepeating("RedBeanInstance", spawnTimeRedBean, spawnTimeRedBean);

        InvokeRepeating("GoldBeanInstance", spawnTimeGoldBean, spawnTimeGoldBean);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        beanPlayerScore.text = playerBeanScore + " ";

        //if (playerBeanScore >= 50)
        if(timeLeft <= 0)
        {
            if(playerBeanScore <=19)
            {
                outro.SetActive(true);
                medals[3].SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SceneManager.UnloadSceneAsync("BeanGame");
                    SceneManager.LoadScene("BeanGame", LoadSceneMode.Additive);
                    outro.SetActive(false);
                    medals[3].SetActive(false);
                }
            }
            
            if(playerBeanScore >= 20 && playerBeanScore <= 39)
            {
                
                medals[0].SetActive(true);
                CompleteLevel();
                if(Input.GetKeyDown(KeyCode.E))
                {
                    SceneManager.UnloadSceneAsync("BeanGame");
                }
            }
            else if (playerBeanScore >=30 && playerBeanScore <= 59)
            {
                
                medals[1].SetActive(true);
                CompleteLevel();
                if(Input.GetKeyDown(KeyCode.E))
                {
                    SceneManager.UnloadSceneAsync("BeanGame");
                }
                
            }
            else if(playerBeanScore >=40)
            {
                
                medals[2].SetActive(true);
                CompleteLevel();
                if(Input.GetKeyDown(KeyCode.E))
                {
                    SceneManager.UnloadSceneAsync("BeanGame");
                }
                
            }

            
        }
    }

    void CompleteLevel()
    {
        myBeanStalkTrigger.SetBeanState1();
        myBeanGuyTrigger.LevelSwitch.SetActive(true);
        myBeanGuyTrigger.beanTexts[3].SetActive(false);
        myBeanGuyTrigger.BeanGame = true;
        myBeanGuyTrigger.beanIntro.SetActive(false);
        outro.SetActive(true);
        

    }
    void BlackBeanInstance()
    {
        //var newBlackBean = GameObject.Instantiate(BlackBean);
        Vector3 position1 = new Vector3(Random.Range(-74.0f, -62.0f), Random.Range(7.0f, 9.0f), 13);
        Instantiate(BlackBean, position1, Quaternion.identity);
    }

    void RedBeanInstance()
    {
        //var newRedBean = GameObject.Instantiate(RedBean);
        Vector3 position2 = new Vector3(Random.Range(-74.0f, -62.0f), Random.Range(9.0f, 12.0f), 13);
        Instantiate(RedBean, position2, Quaternion.identity);
    }

    void GoldBeanInstance()
    {
        //var newGoldBean = GameObject.Instantiate(GoldBean);
        Vector3 position3 = new Vector3(Random.Range(-74.0f, -62.0f), Random.Range(7.0f, 14.0f), 13);
        Instantiate(GoldBean, position3, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D bean)
    {
      if (bean.gameObject.tag == "Black")
        {
            Destroy(bean.gameObject);
            playerBeanScore = playerBeanScore -1;
            print(playerBeanScore);
        }
      
      else if (bean.gameObject.tag == "Red")
        {
            Destroy(bean.gameObject);
            playerBeanScore = playerBeanScore + 3;
            print(playerBeanScore);
        }

      else if (bean.gameObject.tag == "Gold")
        {
            Destroy(bean.gameObject);
            playerBeanScore = playerBeanScore + 5;
            print(playerBeanScore);
        }
    }
}