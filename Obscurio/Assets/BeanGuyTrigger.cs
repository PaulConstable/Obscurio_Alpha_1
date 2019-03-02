using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanGuyTrigger : MonoBehaviour {

    private int speechCheck = 1;
    
    [SerializeField] public GameObject[] beanTexts;
    public bool text;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && speechCheck ==1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                beanTexts[0].SetActive(true);
                speechCheck = 2;
                print("Speech1");
                

            }

        }

        if(collision.gameObject.tag == "Player" && speechCheck ==2)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                beanTexts[0].SetActive(false);
                beanTexts[1].SetActive(true);
                speechCheck = 3;
                print("Speech2");
            }
        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && speechCheck == 2)
        {
            beanTexts[0].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && speechCheck == 3)
        {
            beanTexts[1].SetActive(false);
        }
    }
}
