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
    WellGameTrigger myWellGameTrigger;

    public static bool youWin;
    

    // Use this for initialization
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();
        myBeanStalkTrigger = FindObjectOfType<BeanStalkTrigger>();
        myWellGameTrigger = FindObjectOfType<WellGameTrigger>();
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
        myWellGameTrigger.RemoveButton();

        SceneManager.UnloadSceneAsync("Well-Jump_Game");
        
 


    }
}
