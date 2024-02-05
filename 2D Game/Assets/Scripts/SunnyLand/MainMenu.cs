using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject options, levels;

public void startGame(){
    SceneManager.LoadScene("SunnyLand");
    print("Clicking");
}

public void ShowLevels(){
    print("levels");
    options.active = false;
    levels.active = true;
}

public void Back(){
    print("back");
    levels.active = false;
    options.active = true;
}

}
