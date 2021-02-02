using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyGameEvent onDestroyEnemy;
    [SerializeField] private EnemyGameEvent onInitializeEnemy;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private List<GameObject> gifts;

    private bool isShooting;
    private float currentHp;
    private EnemyData enemyData;
    private Transform player;
    private bool isAlive;

    public void Link(EnemyData enemydata, Transform playerReference)
    {
        isAlive = true;
        enemyData = enemydata;
        transform.GetChild(0).GetComponent<MeshRenderer>().material.color = enemyData.Color;
        agent.speed = enemyData.SpeedMovement;
        currentHp = enemyData.MaxHp;
        player = playerReference;
        onInitializeEnemy?.Raise(this);
    }

    private void Update()
    {
        if (!isShooting)
        {

            agent.SetDestination(player.position);

            if (Vector3.Distance(transform.position, player.position) < 3.5f)
            {
                isShooting = true;
                EnemyBullet enemyBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity).GetComponent<EnemyBullet>();
                enemyBullet.Init(enemyData.Color, enemyData.Damage, player);
                StartCoroutine("Shot");
            }
        }
    }

    public void Injure(float powerBullet)
    {
        currentHp -= powerBullet;
        if (currentHp <= 0 && isAlive)
        {
            RandomGift();
            isAlive = false;
            onDestroyEnemy?.Raise(this);
            Destroy(this.gameObject);
        }
    }

    public void InjureByPoison(float perecentage)
    {
        currentHp -= ((perecentage/100)*currentHp);
        if (currentHp <= 0 && isAlive)
        {
            RandomGift();
            isAlive = false;
            onDestroyEnemy?.Raise(this);
            Destroy(this.gameObject);
        }
    }

    private void RandomGift()
    {
        if(Random.Range(0,100) > 50)
            if(Random.Range(0, 100) > 50)
                Instantiate(gifts[0], transform.position, Quaternion.identity);
            else
                Instantiate(gifts[Random.Range(0, gifts.Count)], transform.position, Quaternion.identity);

    }

    public Team GetTeam()
    {
        return enemyData.Team;
    }


    IEnumerator Shot()
    {
        isShooting = true;
        yield return new WaitForSeconds(2);
        isShooting = false;
    }
}
