using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Sprite[] cardFaces;
    public Sprite cardBack;
    public GameObject[] cards;

    private bool initial = false;
    private int matches = 13;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!initial)
            initialiseCards();

        if (Input.GetMouseButtonUp(0))
            checkCards();
	}

    void initialiseCards()
    {
        for (int i =0; i<2; i++)
        {
            for (int p =1; p<14; p++)
            {
                bool test = false;
                int choice = 0;
                while(!test)
                {
                    choice = Random.Range(0, cards.Length);
                    test = !(cards[choice].GetComponent<CardFlipGame>().initialise);
                }
                cards[choice].GetComponent<CardFlipGame>().cardValues = p;
                cards[choice].GetComponent<CardFlipGame>().initialise = true;
            }
        }

        foreach (GameObject c in cards)
            c.GetComponent<CardFlipGame>().createGraphics();

        if (!initial)
            initial = true;
    }

    public Sprite getcardBack()
    {
        return cardBack;
    }

    public Sprite getcardFront(int p)
    {
        return cardFaces[p - 1];
    }


void checkCards()
    {
        List<int> c = new List<int>();

        for (int i=0; i<cards.Length; i++)
        {
            if (cards[i].GetComponent<CardFlipGame>().states == 1)
                c.Add(i);
        }

        if (c.Count == 2)
            cardComparison(c);
    }

    void cardComparison(List<int> c)
    {
        CardFlipGame.stay = true;

        int x = 0;

        if (cards [c [0]].GetComponent<CardFlipGame>().cardValues == cards [c [1]].GetComponent<CardFlipGame>().cardValues)
        {
            x = 2;
            matches--;
            if (matches==0)
            {
                Debug.Log("matches complete");
            }
        }

        for(int i=0; i<c.Count; i++)
        {
            cards[c [i]].GetComponent<CardFlipGame>().states = x;
            cards[c[i]].GetComponent<CardFlipGame>().falsecheck();
        }
    }

}
