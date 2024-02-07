using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using UnityEngine;
using UnityEngine.U2D.IK;
using Newtonsoft.Json.Linq;
using UnityEngine.UI;
using System.Linq;

//Package to import in unity: https://github.com/jilleJr/Newtonsoft.Json-for-Unity.git#upm
//Command to import in C# project: dotnet add package Newtonsoft.Json
public class CardGenerator : MonoBehaviour
{
    public GameObject cardObject;
    //Path from assets folder to the JSON file with each card info
    public string pathToJson;


    void Start()
    {
        string jsonString = File.ReadAllText(Path.Combine(Application.dataPath, pathToJson));

        JArray cardArray = JArray.Parse(jsonString);


        foreach (JObject card in cardArray)
        {
            GameObject newCard = Instantiate(this.cardObject, this.transform);
            // newCard.GetComponent<Card>().setValues(card["name"].ToString());
            print("levels" + card["levels"]);
            print("count" + card["levels"].Count());

        }


    }

}
