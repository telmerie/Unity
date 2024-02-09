using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public enum Scene : int{
    Main,
    Game
}

public class GameManager : MonoBehaviour
{
    public Scene currentScene;

    public static GameManager instance;

    public int realoaded {get; set;} = 0;
    
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
