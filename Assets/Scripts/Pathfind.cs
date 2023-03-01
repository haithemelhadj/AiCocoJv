using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfind : MonoBehaviour
{
    public Transform target;
    public float speed = 5.0f;
    public float moveDistance = 3.0f;

    private Vector3 startPosition;
    private Vector3 TP;
    
    // Update is called once per frame
    void Update()
    {
        TP = target.position;

        Vector3 targetDirection = TP - transform.position;
        targetDirection.y = 0.0f;
        targetDirection.Normalize();

        RaycastHit hitInfo;
        if (Physics.Raycast(transform.position, targetDirection, out hitInfo, moveDistance))
        {
            Vector3 normal = hitInfo.normal;
            normal.y = 0.0f;
            targetDirection = Vector3.Cross(normal, Vector3.up);
        }

        transform.position += targetDirection * speed * Time.deltaTime;
    }

}
