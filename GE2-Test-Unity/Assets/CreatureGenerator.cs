using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureGenerator : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] private float length = 10f;
    [SerializeField] private float frequency;
    [SerializeField] private float startAngle = 0f;
    [SerializeField] private Vector3 baseSize;
    [SerializeField] private float multiplier = 2f;
    
    private void OnDrawGizmos()
    {
        baseSize *= multiplier;
        //start_angle = Mathf.Sin()
        for (var i = 0; i < length; i++)
        {
            Gizmos.DrawCube(transform.position, baseSize);
        }
    }
}
