using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public enum Scene {
    Main,
    Game
}

public class GameManager : MonoBehaviour
{
    public Scene currentScene;

    public static GameManager instance;

    private int realoaded = 0;

    void Awake(){
       
        if(instance != null){
            Destroy(gameObject);
            return;
        } 

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void timesReloaded(){
        realoaded ++;
        print("realoaded: " +realoaded);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
