using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [Header("Settings for zooming camera")]
    [Range(60,100)]
    [SerializeField] private float normalZoom;
    [Range(60, 100)]
    [SerializeField] private float maxZoom;
    [SerializeField] private Camera playerCamera;

    private float value;
    
    // Update is called once per frame
    void Update()
    {

        if (Mathf.Abs(Input.GetAxis("Horizontal")) >Mathf.Abs(Input.GetAxis("Vertical")))
            value = Mathf.Abs(Input.GetAxis("Horizontal"));
        else
            value = Mathf.Abs(Input.GetAxis("Vertical"));

        playerCamera.fieldOfView = Mathf.Lerp(normalZoom, maxZoom, value);
    }
}
