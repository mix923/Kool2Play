using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    [SerializeField] private FloatGameEvent onInjuryPlayer;
    [SerializeField] private float damage;
    [SerializeField] private Transform player;

    public void Init(Color color, float damageBullet, Transform playerReference)
    {
        transform.GetChild(0).GetComponent<MeshRenderer>().material.color = color;
        player = playerReference;
        damage = damageBullet;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, Time.deltaTime * 20f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name =="Player")
        {
            onInjuryPlayer?.Raise(damage);        
        }
    }
}
