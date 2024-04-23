using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureGenerator : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] private int length = 10;
    [SerializeField] private float frequency;
    [SerializeField] private float startAngle = 0f;
    [SerializeField] private Vector3 baseSize;
    [SerializeField] private float multiplier = 2f;
    
    private void OnDrawGizmos()
    {
        for (var i = 0; i < length; i++)
        {
            var a = Mathf.Sin(startAngle) * frequency * i;
            var rot = new Quaternion(transform.rotation.x, a, transform.rotation.z, transform.rotation.w);
            //Debug.Log(t);
            transform.rotation = rot;
            var x = transform.position.x + (baseSize.x * multiplier * i);
            var pos = new Vector3(x, transform.position.y, transform.position.z);
            Gizmos.DrawCube(pos, baseSize * multiplier);
        }
    }
}
