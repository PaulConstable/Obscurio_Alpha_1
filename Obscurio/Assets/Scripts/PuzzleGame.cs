﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGame : MonoBehaviour
{
 
    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!GameControl.youWin)
        {

            transform.Rotate(0f, 0f, 90f);
        }
    }

}
