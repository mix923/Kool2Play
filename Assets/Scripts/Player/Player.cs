using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    void Start()
    {
        Vector3 worldPositionMiddleCenterScreen;
        Plane plane = new Plane(Vector3.up, 0);
        float distance;

        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2));
        if (plane.Raycast(ray, out distance))
        {
            worldPositionMiddleCenterScreen = ray.GetPoint(distance);
            transform.position = new Vector3(worldPositionMiddleCenterScreen.x, transform.position.y, worldPositionMiddleCenterScreen.z);
        }
    }  
}
