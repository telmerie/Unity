using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents instance;

    void Awake(){
        instance = this;
    }
    
    public event Action onJump;

    public void jumpTrigger(){
        if(onJump != null){
            onJump();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
