using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private SprintValue sprintValue;


    [SerializeField] private float vertical;
    [SerializeField] private float horizontal;
    [SerializeField] private float currentSpeed;
    [Header("Settings for movement player")]
    [Range(1,10)]
    [SerializeField] private float normalSpeed;
    [Range(1, 10)]
    [SerializeField] private float sprintSpeed;

    public Vector3 direction;


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.LeftShift) && sprintValue.CurrentValue >= 0)
        {
            currentSpeed = sprintSpeed;
            sprintValue.CurrentValue -= 4f * Time.deltaTime;
        }
        else
            currentSpeed = normalSpeed;

        direction = new Vector3(horizontal, 0, vertical);
        direction = direction.normalized * Time.deltaTime * currentSpeed;

        transform.position += direction;

        LookAtMouse();

    }

    public void LookAtMouse()
    {
        Vector3 worldPositionMouse;
        Plane plane = new Plane(Vector3.up, 0);
        float distance;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out distance))
        {
            worldPositionMouse = ray.GetPoint(distance);
            transform.LookAt(new Vector3(worldPositionMouse.x, transform.position.y, worldPositionMouse.z));
        }
    }

}
