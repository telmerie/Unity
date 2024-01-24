using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    public GameObject[] maps;
    private System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("Exit");
            generateMap();
        }

    }

    private void generateMap()
    {
        Instantiate(maps[random.Next(0, maps.Length-1)], new Vector3(transform.position.x - 1, transform.position.y), transform.rotation);
    }
}

