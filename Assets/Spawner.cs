using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPrefabs;
    public float enemySpeed = 1f;

    private float timeUntilEnemySpawn = 0f;
    private float elapsedTime = 0f;
    private float speedTime = 0f;
    private float enemySpawnTime;

    private void Start()
    {
        UpdateEnemySpawnTime();
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        speedTime += Time.deltaTime;
        UpdateEnemySpawnTime();
        SpawnLoop();
    }

    private void UpdateEnemySpawnTime()
    {

        if (elapsedTime < 15) // 0 - 1 phút
        {
            enemySpawnTime = Random.Range(5f, 7f);
            enemySpeed = 1f;
        }
        else if (elapsedTime < 120) // 1 - 2 phút
        {
            enemySpawnTime = Random.Range(8f, 12f);
            enemySpeed = 1.25f;
        }
        else if (elapsedTime < 240) // 2 - 4 phút
        {
            enemySpawnTime = Random.Range(6f, 10f);
            enemySpeed = 1.5f;
        }
        else // ngoài 4 phút
        {
            enemySpawnTime = Random.Range(4f, 8f);
            enemySpeed = 2.3f;
        }
    }

    private void SpawnLoop()
    {
        timeUntilEnemySpawn += Time.deltaTime;
        if (timeUntilEnemySpawn >= enemySpawnTime)
        {
            Spawn();
            timeUntilEnemySpawn = 0f;
            UpdateEnemySpawnTime(); // Cập nhật thời gian spawn sau mỗi lần spawn
        }
    }

    private void Spawn()
    {
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject spawnedEnemy = Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
        Rigidbody2D enemyRB = spawnedEnemy.GetComponent<Rigidbody2D>();
        if (enemyRB != null)
        {
            enemyRB.velocity = Vector2.left * enemySpeed;
        }
    }
}