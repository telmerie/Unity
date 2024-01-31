using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents instance;

    public void Awake(){
        instance = this;
    }
    
    public event Action onJumpTrigger;

    public void iAmActivatingTheJumpTrigger(){
        if(onJumpTrigger != null){
            onJumpTrigger();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
