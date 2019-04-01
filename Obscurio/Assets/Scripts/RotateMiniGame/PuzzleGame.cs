using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGame : MonoBehaviour
{

    GameControl MygameControl;
    
    public float timeTaken = 0;

    public void Start()
    {
        MygameControl = FindObjectOfType<GameControl>();


    }

    private void Update()
    {
        if (MygameControl.isOutroScene == false)
        {
            timeTaken += Time.deltaTime;
        }
    }

    private void OnMouseDown()
    {
        
            if (!GameControl.youWin)
            {
                
                transform.Rotate(0f, 0f, 90f);
            }
        
    }

}
