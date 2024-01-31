using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {

        GameEvents.instance.onJump += onJump;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;

        }
    }

    private void onJump(){
        print("Player is jumping");
    }


}
