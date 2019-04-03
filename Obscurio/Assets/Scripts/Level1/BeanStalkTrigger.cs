using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeanStalkTrigger : MonoBehaviour {

    [SerializeField] public GameObject eButton;
    [SerializeField] public GameObject[] stalks;
    public int beanState = 0;

    BeanGuyTrigger myBeanGuyTrigger;

    public AudioClip speech1;
    public AudioSource audio;

    public AudioClip speech2;
    public AudioSource audio2;

    public AudioClip speech3;
    public AudioSource audio3;

    public void Start()
    {
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();
        audio.GetComponent<AudioSource>();
        audio2.GetComponent<AudioSource>();
        audio3.GetComponent<AudioSource>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && beanState == 1)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                stalks[0].SetActive(true);
                myBeanGuyTrigger.BeanPlantedfunc();
                audio.PlayOneShot(speech1, 1f);

            }
        }
        if (collision.gameObject.tag == "Player" && beanState == 2)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                stalks[1].SetActive(true);
                stalks[0].SetActive(false);
                myBeanGuyTrigger.RemoveCan();
                audio2.PlayOneShot(speech1, 1f);
            }
        }
        if (collision.gameObject.tag == "Player" && beanState == 3)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                stalks[2].SetActive(true);
                stalks[1].SetActive(false);
                myBeanGuyTrigger.RemovePotion();
                beanState = 4;
                audio3.PlayOneShot(speech1, 1f);

            }
        }
        if(collision.gameObject.tag == "Player" && beanState == 4)
        {
            eButton.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("ClimbingBean");
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

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && beanState == 4)
        {
            eButton.SetActive(false);
        }
    }

}
