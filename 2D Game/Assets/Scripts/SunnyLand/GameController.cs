using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

enum Level {
    One, 
    Two,
    superAweseomeLevel, 

    theOneNoOneCanPass
}

public class GameController : MonoBehaviour
{


    public static bool isPaused = false;
    private Level level = Level.theOneNoOneCanPass;


    // Start is called before the first frame update
    void Start()
    {

        GameEvents.instance.onJumpTrigger += onJump;
        GameEvents.instance.onJumpTrigger += test;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
            level = Level.Two;

        }
    }

    private void onJump(){
        print("Player is jumping");
    }

    private void test(){
        print("I am prove that this is wokring");
    }


}
