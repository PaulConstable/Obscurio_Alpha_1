using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WellGameTrigger : MonoBehaviour
{
    public static bool isLoaded = false;
    BeanGuyTrigger myBeanGuyTrigger;

    [SerializeField] public GameObject EBUtton;

    // Use this for initialization
    void Start()
    {
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && myBeanGuyTrigger.WellCheck == true)
        {
            EBUtton.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isLoaded == false && myBeanGuyTrigger.WellCheck == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isLoaded = true;
                SceneManager.LoadScene("Well-Jump_Game", LoadSceneMode.Additive);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            EBUtton.SetActive(false);
        }

    }

    public void RemoveButton()
    {
        EBUtton.SetActive(false);
    }

    public void isloadedreference()
    {
        isLoaded = false;
    }

}
