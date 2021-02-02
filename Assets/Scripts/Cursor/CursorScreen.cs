using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScreen : MonoBehaviour
{
    private RectTransform cursor;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        cursor = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        cursor.anchoredPosition = Input.mousePosition;
    }
}
