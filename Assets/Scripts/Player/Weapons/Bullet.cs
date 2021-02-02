using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed;
    private float damage;

    public void Init(float speedBullet, float damageBullet, Color color)
    {
        speed = speedBullet;
        damage = damageBullet;
        transform.GetComponent<MeshRenderer>().material.color = color;
    }

    private void Update()
    {
        transform.position += transform.TransformDirection(-transform.forward) * Time.deltaTime * speed;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        else if(other.gameObject.tag == "Enemy")
        {
            if (other.GetComponent<Enemy>() != null)
            {
                other.GetComponent<Enemy>().Injure(damage);
                Destroy(this.gameObject);
            }
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Wall")
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}
}
