using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    [SerializeField] private Color colorPrefab; // Only for better distinguish all Ability in game 

    [SerializeField] private GameEvent OnPickUpObject;

    public void Start()
    {
        GetComponent<MeshRenderer>().material.color = colorPrefab;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            OnPickUpObject?.Raise();
            Destroy(this.gameObject);
        }
    }
}
