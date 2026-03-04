using System;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    
    
    [SerializeField] private Transform target;

    [SerializeField] private Vector3 offset;
    [SerializeField] private Vector3 rotation;

    private void LateUpdate() // Update ve FixedUpdate ten sonra çalışır
    {
        Vector3 targetPos = target.position + offset;
        transform.position = Vector3.Slerp(transform.position, targetPos, Time.deltaTime * speed);
        // transform.LookAt(target.position + rotation);
    }
}
