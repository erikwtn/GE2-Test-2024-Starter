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
    [SerializeField] private Color c = new(0,0,1);
    private float _t = 0;
    
    private void OnDrawGizmos()
    {
	    for (var i = 0; i < length; i++)
	    {
		    var a = Mathf.Sin(_t) * startAngle;
		    _t += Mathf.PI * Time.deltaTime * frequency;
		    Debug.Log(a);
		    var bs = new Vector3(baseSize.x, baseSize.y * a, baseSize.z);
		    var x = transform.position.x + (baseSize.x * multiplier * i);
		    var pos = new Vector3(x, transform.position.y, transform.position.z);
		    c.b = c.b * i / 100;
		    Gizmos.color = c;
		    Gizmos.DrawCube(pos, bs * multiplier);
	    }
    }
}
