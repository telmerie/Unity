using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;

public class Card : MonoBehaviour
{
    public TMP_Text text;
    

    public void setValues(string name, String text){
        gameObject.name = name;
        this.text.text = text;
    }

    public void onClick(){
        print($"Clicked on {gameObject.name}");
    }
}
