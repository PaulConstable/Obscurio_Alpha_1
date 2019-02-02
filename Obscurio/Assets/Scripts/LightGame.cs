using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightGame : MonoBehaviour {

    [SerializeField] public Button button;

    public void ChangeColor()
    {
        

        var color = button.colors;
        color.normalColor = Color.red;
        button.colors = color;
    }

	
}

