using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WellWin : MonoBehaviour
{
    [SerializeField]
    private GameObject winText;

    BeanGuyTrigger myBeanGuyTrigger;
    BeanStalkTrigger myBeanStalkTrigger;

    public static bool youWin;
    

    // Use this for initialization
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();
        myBeanStalkTrigger = FindObjectOfType<BeanStalkTrigger>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        youWin = true;
        winText.SetActive(true);
        myBeanGuyTrigger.CanSpeechBubbleRemoved();
        myBeanGuyTrigger.DisplayCan();
        myBeanGuyTrigger.returnState();
        myBeanStalkTrigger.SetBeanState2();

        SceneManager.UnloadSceneAsync("Well-Jump_Game");
        
 


    }
}
