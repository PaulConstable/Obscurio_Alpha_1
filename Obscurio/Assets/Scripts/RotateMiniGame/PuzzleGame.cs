using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGame : MonoBehaviour
{

    
    public float timeTaken = 0;

    public void Start()
    {



    }

    private void Update()
    {
        timeTaken += Time.deltaTime;
    }

    private void OnMouseDown()
    {
        
            if (!GameControl.youWin)
            {
                
                transform.Rotate(0f, 0f, 90f);
            }
        
    }

}
