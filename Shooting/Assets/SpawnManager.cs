using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPreFab;
    private float range=12;
    public int enemyCount;
    public playerController player;
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy(5);
        player = GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        //Debug.Log(player.isAlive);
        if (enemyCount <5)  //&& player.isAlive
        {
           spawnEnemy(1);
        }
    }
    void spawnEnemy(int totalPlayer)
    {
        for (int i = 0; i < totalPlayer; i++)
        {
            Instantiate(enemyPreFab, GenerateSpawnPos(), enemyPreFab.transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPos()
    {
        float spawnposX = Random.Range(-range, range);
        float spawnposZ = Random.Range(-range, range);
        Vector3 spawnPos = new Vector3(spawnposX, 0, spawnposZ);
        return spawnPos;
    }
}
