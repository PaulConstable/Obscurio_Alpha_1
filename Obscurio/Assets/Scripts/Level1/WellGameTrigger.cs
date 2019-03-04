using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WellGameTrigger : MonoBehaviour
{
    public static bool isLoaded = false;
    BeanGuyTrigger myBeanGuyTrigger;

    // Use this for initialization
    void Start()
    {
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isLoaded == false && myBeanGuyTrigger.WellCheck == true)
        {
            isLoaded = true;
            SceneManager.LoadScene("Well-Jump_Game", LoadSceneMode.Additive);
        }
       
    }

    public void isloadedreference()
    {
        isLoaded = false;
    }

}
