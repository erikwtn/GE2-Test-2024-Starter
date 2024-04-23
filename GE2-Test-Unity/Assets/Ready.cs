using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{
	[SerializeField] private GameObject head, boid;
	[SerializeField] private int size = 4;
	[SerializeField] private float dist = 1f;
	private SpineAnimator _spineAnimator;
	private void Start()
	{
		Time.timeScale = 0;
		var h = Instantiate(head, transform.position, Quaternion.identity, transform.parent);
		_spineAnimator = h.GetComponent<SpineAnimator>();
		
		for (var i = 0; i < size; i++)
		{
			var newZ = transform.position.z - (h.transform.localScale.z * i) - dist;
			var newPos = new Vector3(transform.position.x, transform.position.y, newZ);
			var b = Instantiate(boid, newPos, Quaternion.identity, transform.parent);
			_spineAnimator.bones[i] = b;
		}
	}

	private void Update()
	{
		if (!Input.GetKeyDown(KeyCode.P)) return;
		
		Time.timeScale = Time.timeScale switch
		{
			1 => 0,
			0 => 1,
			_ => 1
		};
	}
}
