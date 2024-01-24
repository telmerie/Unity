using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float spawnRate = 5;
    private float timer = 0;

    private System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("right"))
        {
            if (timer < spawnRate)
            {
                timer = timer + Time.deltaTime;
            }
            else
            {
                spawnEnemy();
                timer = 0;
            }
        }


    }

    void spawnEnemy()
    {
        Instantiate(enemies[random.Next(0, enemies.Length-1)], transform.position, transform.rotation);
    }
}

