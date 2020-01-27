using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragBrick : MonoBehaviour
{
    private float zAxis;
    private Vector3 mouseSet;

    private Vector3 GetMouseCoor()
    {
        Vector3 currentPoint = Input.mousePosition;
        currentPoint.z = zAxis;
        return Camera.main.ScreenToWorldPoint(currentPoint);

    }

    void OnMouseDown()
    {
        zAxis = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mouseSet = gameObject.transform.position - GetMouseCoor();
    }
    void OnMouseDrag()
    {
        transform.position = GetMouseCoor() + mouseSet;
    }
}