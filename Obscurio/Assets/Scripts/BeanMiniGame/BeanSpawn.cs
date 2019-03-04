using System.Collections;
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


    // text
    public Text beanPlayerScore;

    private float playerBeanScore = 0;
    
    void Start()
    {

        

        InvokeRepeating("BlackBeanInstance", spawnTimeBlackBean, spawnTimeBlackBean);

        InvokeRepeating("RedBeanInstance", spawnTimeRedBean, spawnTimeRedBean);

        InvokeRepeating("GoldBeanInstance", spawnTimeGoldBean, spawnTimeGoldBean);
    }

    // Update is called once per frame
    void Update()
    {
        beanPlayerScore.text = playerBeanScore + " / 50";

        if (playerBeanScore == 50)
        {
            SceneManager.UnloadSceneAsync("Well-Jump_Game");
        }
    }
    void BlackBeanInstance()
    {
        //var newBlackBean = GameObject.Instantiate(BlackBean);
        Vector3 position1 = new Vector3(Random.Range(-6.0f, 6.0f), Random.Range(7.0f, 9.0f), Random.Range(-6.0f, 6.0f));
        Instantiate(BlackBean, position1, Quaternion.identity);
    }

    void RedBeanInstance()
    {
        //var newRedBean = GameObject.Instantiate(RedBean);
        Vector3 position2 = new Vector3(Random.Range(-6.0f, 6.0f), Random.Range(9.0f, 12.0f), Random.Range(-6.0f, 6.0f));
        Instantiate(RedBean, position2, Quaternion.identity);
    }

    void GoldBeanInstance()
    {
        //var newGoldBean = GameObject.Instantiate(GoldBean);
        Vector3 position3 = new Vector3(Random.Range(-6.0f, 6.0f), Random.Range(7.0f, 14.0f), Random.Range(-6.0f, 6.0f));
        Instantiate(GoldBean, position3, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D bean)
    {
      if (bean.gameObject.tag == "Black")
        {
            Destroy(bean.gameObject);
            playerBeanScore = playerBeanScore + 2;
            print(playerBeanScore);
        }
      
      else if (bean.gameObject.tag == "Red")
        {
            Destroy(bean.gameObject);
            playerBeanScore = playerBeanScore + 5;
            print(playerBeanScore);
        }

      else if (bean.gameObject.tag == "Gold")
        {
            Destroy(bean.gameObject);
            playerBeanScore = playerBeanScore + 10;
            print(playerBeanScore);
        }
    }
}