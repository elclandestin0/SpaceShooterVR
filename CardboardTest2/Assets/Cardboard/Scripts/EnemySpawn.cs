using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public GameObject EnemyBarrel; 

	public GameObject Enemy; 

	public float countdown = 150.0f;
    private System.Random ran;

	//public GameObject temporaryBulletHandler;


	public float forwardForce;

	// Use this for initialization
	void Start () {
        ran = new System.Random();
        

	}

	// Update is called once per frame
	void Update () {
		//float time = 0.5f; 
		countdown -= Time.deltaTime; 
		if (countdown <= 0.0f) 
		{
			GameObject temporaryEnemyHandler;

			temporaryEnemyHandler = Instantiate (Enemy, EnemyBarrel.transform.position, EnemyBarrel.transform.rotation) as GameObject;

			temporaryEnemyHandler.transform.Rotate (Vector3.left * 90);

            temporaryEnemyHandler.transform.position = new Vector3(ran.Next(20), ran.Next(20), 40);

			Rigidbody temporaryRigidBody;
			temporaryRigidBody = temporaryEnemyHandler.GetComponent<Rigidbody> ();

			temporaryRigidBody.AddForce (transform.forward * forwardForce);

			Destroy (temporaryEnemyHandler, 5.0f);

            countdown = 0.05f;

		}
	}


}