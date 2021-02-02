using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private List<Transform> spawnPoints; // 0 - red, 1 - green, 2 - blue, 3 - yellow, 

    [SerializeField] private EnemyData redEnemy;
    [SerializeField] private EnemyData greenEnemy;
    [SerializeField] private EnemyData blueEnemy;
    [SerializeField] private EnemyData yellowEnemy;
    [SerializeField] private GameObject enemyPrefab;



    public void StartGame(int value)
    {
        spawnPoints[0].GetComponent<MeshRenderer>().material.color = redEnemy.Color;
        spawnPoints[1].GetComponent<MeshRenderer>().material.color = greenEnemy.Color;
        spawnPoints[2].GetComponent<MeshRenderer>().material.color = blueEnemy.Color;
        spawnPoints[3].GetComponent<MeshRenderer>().material.color = yellowEnemy.Color;


        if (value == 0 ) // only red
        {
            StartCoroutine("SpawnRedEnemies");
            spawnPoints[0].gameObject.SetActive(true);
            spawnPoints[1].gameObject.SetActive(false);
            spawnPoints[2].gameObject.SetActive(false);
            spawnPoints[3].gameObject.SetActive(false);
        }
        else if(value == 1) // only red + green
        {
            StartCoroutine("SpawnRedEnemies");
            StartCoroutine("SpawnGreenEnemies");
            spawnPoints[0].gameObject.SetActive(true);
            spawnPoints[1].gameObject.SetActive(true);
            spawnPoints[2].gameObject.SetActive(false);
            spawnPoints[3].gameObject.SetActive(false);
        }
        else if (value == 2) // only red + green + blue
        {
            StartCoroutine("SpawnRedEnemies");
            StartCoroutine("SpawnGreenEnemies");
            StartCoroutine("SpawnBlueEnemies");
            spawnPoints[0].gameObject.SetActive(true);
            spawnPoints[1].gameObject.SetActive(true);
            spawnPoints[2].gameObject.SetActive(true);
            spawnPoints[3].gameObject.SetActive(false);
        }
        else // only red + green + blue + yellow
        {
            spawnPoints[0].gameObject.SetActive(true);
            spawnPoints[1].gameObject.SetActive(true);
            spawnPoints[2].gameObject.SetActive(true);
            spawnPoints[3].gameObject.SetActive(true);
            StartCoroutine("SpawnRedEnemies");
            StartCoroutine("SpawnGreenEnemies");
            StartCoroutine("SpawnBlueEnemies");
            StartCoroutine("SpawnYellowEnemies");
        }
    }

    IEnumerator SpawnRedEnemies() 
    {
        for(int i = 0; i < 20; i++)
        {
            Enemy enemy = Instantiate(enemyPrefab, spawnPoints[0].position, Quaternion.identity).GetComponent<Enemy>();
            enemy.Link(redEnemy, player);
            yield return new WaitForSeconds(redEnemy.SpawnDelay);
        }
    }

    IEnumerator SpawnGreenEnemies()
    {
        for (int i = 0; i < 20; i++)
        {
            Enemy enemy = Instantiate(enemyPrefab, spawnPoints[1].position, Quaternion.identity).GetComponent<Enemy>();
            enemy.Link(greenEnemy, player);
            yield return new WaitForSeconds(greenEnemy.SpawnDelay);
        }
    }

    IEnumerator SpawnBlueEnemies()
    {
        for (int i = 0; i < 20; i++)
        {
            Enemy enemy = Instantiate(enemyPrefab, spawnPoints[2].position, Quaternion.identity).GetComponent<Enemy>();
            enemy.Link(blueEnemy, player);
            yield return new WaitForSeconds(blueEnemy.SpawnDelay);
        }
    }

    IEnumerator SpawnYellowEnemies()
    {
        for (int i = 0; i < 20; i++)
        {
            Enemy enemy = Instantiate(enemyPrefab, spawnPoints[3].position, Quaternion.identity).GetComponent<Enemy>();
            enemy.Link(yellowEnemy, player);
            yield return new WaitForSeconds(yellowEnemy.SpawnDelay);
        }
    }

}
