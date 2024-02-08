using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     GameManager.instance.currentScene = Scene.Game;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
