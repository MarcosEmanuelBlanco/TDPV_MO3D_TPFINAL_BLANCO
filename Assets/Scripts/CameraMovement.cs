using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target; // Referencia al transform del cubo
    public Vector3 offset = new(0f, 5f, -10f); // Ajusta la posici�n relativa de la c�mara

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(target.position);
        }
    }
}
