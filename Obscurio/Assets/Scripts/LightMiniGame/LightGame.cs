using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LightGame : MonoBehaviour
{

    LoadingLightGame myLightGame;

    [SerializeField] public Button button1;
    [SerializeField] public Button button2;
    [SerializeField] public Button button3;
    [SerializeField] public Button button4;
    [SerializeField] public Button button5;
    [SerializeField] public Button button6;
    [SerializeField] public Button button7;
    [SerializeField] public Button button8;
    [SerializeField] public Button button9;
    public bool check1 = false;
    public bool check2 = false;
    public bool check3 = false;
    public bool check4 = false;
    public bool check5 = false;
    public bool check6 = false;
    public bool check7 = false;
    public bool check8 = false;
    public bool check9 = false;


    public void Start()
    {
        myLightGame = FindObjectOfType<LoadingLightGame>();
    
    }

    public void button1red()
    {
        check1 = true;
        var color1 = button1.colors;
        color1.normalColor = Color.red;
        color1.highlightedColor = Color.red;
        color1.pressedColor = Color.red;
        button1.colors = color1;
    }
    public void button1white()
    {
        check1 = false;
        var color1 = button1.colors;
        color1.normalColor = Color.white;
        color1.highlightedColor = Color.white;
        color1.pressedColor = Color.white;
        button1.colors = color1;
    }
    public void button2red()
    {
        check2 = true;
        var color2 = button2.colors;
        color2.normalColor = Color.red;
        color2.highlightedColor = Color.red;
        color2.pressedColor = Color.red;
        button2.colors = color2;
    }
    public void button2white()
    {
        check2 = false;
        var color2 = button2.colors;
        color2.normalColor = Color.white;
        color2.highlightedColor = Color.white;
        color2.pressedColor = Color.white;
        button2.colors = color2;
    }
    public void button3red()
    {
        check3 = true;
        var color3 = button3.colors;
        color3.normalColor = Color.red;
        color3.highlightedColor = Color.red;
        color3.pressedColor = Color.red;
        button3.colors = color3;
    }
    public void button3white()
    {
        check3 = false;
        var color3 = button3.colors;
        color3.normalColor = Color.white;
        color3.highlightedColor = Color.white;
        color3.pressedColor = Color.white;
        button3.colors = color3;
    }
    public void button4red()
    {
        check4 = true;
        var color4 = button4.colors;
        color4.normalColor = Color.red;
        color4.highlightedColor = Color.red;
        color4.pressedColor = Color.red;
        button4.colors = color4;
    }
    public void button4white()
    {
        check4 = false;
        var color4 = button4.colors;
        color4.normalColor = Color.white;
        color4.highlightedColor = Color.white;
        color4.pressedColor = Color.white;
        button4.colors = color4;
    }
    public void button5red()
    {
        check5 = true;
        var color5 = button5.colors;
        color5.normalColor = Color.red;
        color5.highlightedColor = Color.red;
        color5.pressedColor = Color.red;
        button5.colors = color5;
    }
    public void button5white()
    {
        check5 = false;
        var color5 = button5.colors;
        color5.normalColor = Color.white;
        color5.highlightedColor = Color.white;
        color5.pressedColor = Color.white;
        button5.colors = color5;
    }
    public void button6red()
    {
        check6 = true;
        var color6 = button6.colors;
        color6.normalColor = Color.red;
        color6.highlightedColor = Color.red;
        color6.pressedColor = Color.red;
        button6.colors = color6;
    }
    public void button6white()
    {
        check6 = false;
        var color6 = button6.colors;
        color6.normalColor = Color.white;
        color6.highlightedColor = Color.white;
        color6.pressedColor = Color.white;
        button6.colors = color6;
    }
    public void button7red()
    {
        check7 = true;
        var color7 = button7.colors;
        color7.normalColor = Color.red;
        color7.highlightedColor = Color.red;
        color7.pressedColor = Color.red;
        button7.colors = color7;
    }
    public void button7white()
    {
        check7 = false;
        var color7 = button7.colors;
        color7.normalColor = Color.white;
        color7.highlightedColor = Color.white;
        color7.pressedColor = Color.white;
        button7.colors = color7;
    }
    public void button8red()
    {
        check8 = true;
        var color8 = button8.colors;
        color8.normalColor = Color.red;
        color8.highlightedColor = Color.red;
        color8.pressedColor = Color.red;
        button8.colors = color8;
    }
    public void button8white()
    {
        check8 = false;
        var color8 = button8.colors;
        color8.normalColor = Color.white;
        color8.highlightedColor = Color.white;
        color8.pressedColor = Color.white;
        button8.colors = color8;
    }
    public void button9red()
    {
        check9 = true;
        var color9 = button9.colors;
        color9.normalColor = Color.red;
        color9.highlightedColor = Color.red;
        color9.pressedColor = Color.red;
        button9.colors = color9;
    }
    public void button9white()
    {
        check9 = false;
        var color9 = button9.colors;
        color9.normalColor = Color.white;
        color9.highlightedColor = Color.white;
        color9.pressedColor = Color.white;
        button9.colors = color9;
    }

    public void Complete()
    {
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;
        button6.interactable = false;
        button7.interactable = false;
        button8.interactable = false;
        button9.interactable = false;

        myLightGame.CompleteGame();
    }







    public void Button1()
    {
        if(check1== false)
        {
            button1red();
        }
        else
        {
            button1white();
        }
        if (check2 == false)
        {
            button2red();
        }
        else
        {
            button2white();
        }
        if (check4 == false)
        {
            button4red();
        }
        else
        {
            button4white();
        }

        if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true && check9 == true)
        {
            Complete();
        }
    }

    public void Button2()
    {
        if (check2 == false)
        {
            button2red();
        }
        else
        {
            button2white();
        }

        if (check1 == false)
        {
            button1red();
        }
        else
        {
            button1white();
        }

        if (check3 == false)
        {
            button3red();
        }
        else
        {
            button3white();
        }

        if (check5 == false)
        {
            button5red();
        }
        else
        {
            button5white();
        }
        if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true && check9 == true)
        {
            Complete();
        }
    }

    public void Button3()
    {
        if(check3 ==false)
        {
            button3red();
        }
        else
        {
            button3white();
        }
        if (check2 == false)
        {
            button2red();
        }
        else
        {
            button2white();
        }

        if (check6 == false)
        {
            button6red();
        }
        else
        {
            button6white();
        }
        if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true && check9 == true)
        {
            Complete();
        }
    }

    public void Button4()
    {
        if(check4 ==false)
        {
            button4red();
        }
        else
        {
            button4white();
        }
        if (check1 == false)
        {
            button1red();
        }
        else
        {
            button1white();
        }
        if (check5 == false)
        {
            button5red();
        }
        else
        {
            button5white();
        }
        if (check7 == false)
        {
            button7red();
        }
        else
        {
            button7white();
        }
        if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true && check9 == true)
        {
            Complete();
        }
    }

    public void Button5()
    {
        if (check5 == false)
        {
            button5red();
        }
        else
        {
            button5white();
        }
        if (check2 == false)
        {
            button2red();
        }
        else
        {
            button2white();
        }

        if (check4 == false)
        {
            button4red();
        }
        else
        {
            button4white();
        }

        if (check6 == false)
        {
            button6red();
        }
        else
        {
            button6white();
        }
        if (check8 == false)
        {
            button8red();
        }
        else
        {
            button8white();
        }
        if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true && check9 == true)
        {
            Complete();
        }
    }

    public void Button6()
    {
        if (check6 == false)
        {
            button6red();
        }
        else
        {
            button6white();
        }
        if (check3 == false)
        {
            button3red();
        }
        else
        {
            button3white();
        }

        if (check5 == false)
        {
            button5red();
        }
        else
        {
            button5white();
        }
        if (check9 == false)
        {
            button9red();
        }
        else
        {
            button9white();
        }
        if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true && check9 == true)
        {
            Complete();
        }
    }

    public void Button7()
    {
        if(check7 == false)
        {
            button7red();
        }
        else
        {
            button7white();
        }
        if (check4 == false)
        {
            button4red();
        }
        else
        {
            button4white();
        }
        if (check8 == false)
        {
            button8red();
        }
        else
        {
            button8white();
        }
        if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true && check9 == true)
        {
            Complete();
        }
    }

    public void Button8()
    {
        if(check8==false)
        {
            button8red();
        }
        else
        {
            button8white();
        }
        if (check5 == false)
        {
            button5red();
        }
        else
        {
            button5white();
        }
        if (check7 == false)
        {
            button7red();
        }
        else
        {
            button7white();
        }
        if (check9 == false)
        {
            button9red();
        }
        else
        {
            button9white();
        }
        if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true && check9 == true)
        {
            Complete();
        }
    }

    public void Button9()
    {
        if(check9 == false)
        {
            button9red();
        }
        else
        {
            button9white();
        }
        
        if (check6 == false)
        {
            button6red();
        }
        else
        {
            button6white();
        }
        if(check8 == false)
        {
            button8red();
        }
        else
        {
            button8white();
        }
        if (check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true && check9 == true)
        {
            Complete();
        }
    }

    
}

