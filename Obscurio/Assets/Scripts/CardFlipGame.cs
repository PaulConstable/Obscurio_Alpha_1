using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFlipGame : MonoBehaviour {

    public static bool stay = false;

    [SerializeField] private int state;
    [SerializeField] private int cardValue;
    [SerializeField] private bool initial = false;

    private Sprite cardBack;
    private Sprite cardFront;

    private GameObject manager;



	// Use this for initialization
	void Start () {
        state = 1;
        manager = GameObject.FindGameObjectWithTag("Manager");
	}

    public void createGraphics()
    {
        cardBack = manager.GetComponent<GameManager>().getcardBack();
        cardFront = manager.GetComponent<GameManager>().getcardFront(cardValue);

        flipCard();
    }
	
    public void flipCard()
    {
        if (state == 0)
        {
            state = 1;
        }
        else if (state ==1)
        {
            state = 0;
        }
            
                
        if (state == 0 && !stay)
            GetComponent<Image>().sprite = cardBack;
        else if (state == 1 && !stay)
            GetComponent<Image>().sprite = cardFront;
    }

    public int cardValues
    {
        get { return cardValue; }
        set { cardValue = value; }
    }

    public int states
    {
        get { return state; }
        set { state = value; }
    }

    public bool initialise
    {
        get { return initial; }
        set { initial = value; }
    }

    public void falsecheck()
    {
        StartCoroutine(pause ());
    }

    IEnumerator pause()
    {
        yield return new WaitForSeconds(1);
        if (state == 0)
        {
            GetComponent<Image>().sprite = cardBack;
            
        }
        if (state == 1)
        {
            GetComponent<Image>().sprite = cardFront;
            stay = false;
        }
        
    }
    
    

	// Update is called once per frame
	void Update () {
		
	}
}
