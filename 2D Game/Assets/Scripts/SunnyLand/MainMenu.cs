using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject options, levels;

    private string status; 


    void Awake()
    {
        status = "Awake";
        print(status);
        
    }

    void Start(){
        status = "Start";
        print(status);
        GameManager.instance.timesReloaded();
    }

    public void startGame()
    {
        SceneManager.LoadScene("SunnyLand");
        // print("Clicking");
    }

    public void Print(){
        print("clicked");
    }

    public void ReloadScene(){
        SceneManager.LoadScene("Main Scene");

    }

    public void ShowLevels()
    {
        print("levels");
        options.active = false;
        levels.active = true;
    }

    public void Back()
    {
        print("back");
        levels.active = false;
        options.active = true;
    }

}
