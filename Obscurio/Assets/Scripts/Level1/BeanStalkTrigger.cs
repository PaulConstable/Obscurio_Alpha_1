using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanStalkTrigger : MonoBehaviour {

    [SerializeField] public GameObject[] stalks;
    public int beanState = 0;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && beanState ==1)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                stalks[0].SetActive(true);
            }
        }
        if (collision.gameObject.tag == "Player" && beanState == 2)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                stalks[1].SetActive(true);
                stalks[0].SetActive(false);
            }
        }
        if (collision.gameObject.tag == "Player" && beanState == 3)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                stalks[2].SetActive(true);
                stalks[1].SetActive(false);
            }
        }
    }

    public void SetBeanState1()
    {
        beanState = 1;
    }
    public void SetBeanState2()
    {
        beanState = 2;
    }
    public void SetBeanState3()
    {
        beanState = 3;
    }


}
