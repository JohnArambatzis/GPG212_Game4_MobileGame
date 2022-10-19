using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResources : MonoBehaviour
{
    public float timer = 0;
    public float enemyExtraHealth = 0;
    public float bossExtraHealth = 0;


    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        enemyExtraHealth = timer * 0.1f;
        bossExtraHealth = timer;
    }
}
