using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawning : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    private GameObject ballSpawned;

    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ballSpawned == null)
        {
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(spawnAreaMin.x, spawnAreaMax.x), Random.Range(spawnAreaMin.y, spawnAreaMax.y));

        ballSpawned = Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }
}
