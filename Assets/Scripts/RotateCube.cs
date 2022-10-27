using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 100;

    [SerializeField]
    List<Transform> pivots = new List<Transform>();

    private void OnMouseDrag()
    {
        transform.SetParent(null);
        SetParent(transform);
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        // select the axis by which you want to rotate the GameObject
        transform.RotateAround(Vector3.down, XaxisRotation);
        transform.RotateAround(Vector3.right, YaxisRotation);
    }
    private void OnMouseUp()
    {
        SetParent(null);
    }

    void SetParent(Transform _parent)
    {
        for (int i = 0; i < pivots.Count; i++)
        {
            pivots[i].SetParent(_parent);
        }
    }
}

