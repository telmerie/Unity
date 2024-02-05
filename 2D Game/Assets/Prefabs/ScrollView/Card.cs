using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;

public class Card : MonoBehaviour
{
    public TMP_Text text;

    public void setValues(String text){
        this.text.text = text;
    }

    public void onClick(){
        print("Clicked");
    }
}
