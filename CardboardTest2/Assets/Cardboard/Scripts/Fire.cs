using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public GameObject BulletBarrel; 

	public GameObject Bullet; 

	//public GameObject temporaryBulletHandler;


	public float forwardForce;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {

			GameObject temporaryBulletHandler;

			temporaryBulletHandler = Instantiate (Bullet, BulletBarrel.transform.position, BulletBarrel.transform.rotation) as GameObject;

			temporaryBulletHandler.transform.Rotate (Vector3.left * 90); 

			Rigidbody temporaryRigidBody;
			temporaryRigidBody = temporaryBulletHandler.GetComponent<Rigidbody> ();

			temporaryRigidBody.AddForce (transform.forward * forwardForce);

			Destroy (temporaryBulletHandler, 3.0f);
		}
}


}