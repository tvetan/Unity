﻿using UnityEngine;

public class Rotation : MonoBehaviour 
{
	void Update () 
	{
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}