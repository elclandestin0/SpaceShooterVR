using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour 
{
	public GameObject Cube; 
	public GameObject Bullet; 
	
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Cube") 
		{
			GetComponent<Renderer> ().material.color = Color.blue;
		}

	}
}
