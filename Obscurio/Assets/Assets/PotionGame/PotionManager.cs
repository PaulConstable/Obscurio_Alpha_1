using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionManager : MonoBehaviour
{

    public GameObject EyeBall, Frog, DeadFlower, Couldron;

    Vector2 EyeBallIntPos, FrogIntPos, DeadFlowerIntPos;

    // Use this for initialization
    void Start()
    {
        
        EyeBallIntPos = EyeBall.transform.position;
        FrogIntPos = Frog.transform.position;
        DeadFlowerIntPos = DeadFlower.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void DragEyeBall()
    {
        Debug.Log("dragE");
        EyeBall.transform.position = Input.mousePosition;
     
    }

    public void DragFrog()
    {
        Frog.transform.position = Input.mousePosition;
    }

    public void DragDeadFlower()
    {
        DeadFlower.transform.position = Input.mousePosition;
    }

    public void DropEyeBall()
    {
        float Distance = Vector3.Distance(EyeBall.transform.position, Couldron.transform.position);
        if (Distance < 50)
        {
            EyeBall.transform.position = Couldron.transform.position;
        }

        else
        {
            EyeBall.transform.position = EyeBallIntPos;
        }
    }

    public void DropFrog()
    {
        float Distance = Vector3.Distance(Frog.transform.position, Couldron.transform.position);
        if (Distance < 50)
        {
            Frog.transform.position = Couldron.transform.position;
        }

        else
        {
            Frog.transform.position = FrogIntPos;
        }
    }

    public void DropDeadFlower()
    {
        float Distance = Vector3.Distance(DeadFlower.transform.position, Couldron.transform.position);
        if (Distance < 50)
        {
            DeadFlower.transform.position = Couldron.transform.position;
        }

        else
        {
            DeadFlower.transform.position = DeadFlowerIntPos;
        }
    }
    
}
