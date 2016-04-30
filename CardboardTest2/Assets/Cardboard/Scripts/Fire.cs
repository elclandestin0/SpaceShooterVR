using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public GameObject BulletBarrel; 

	public GameObject Bullet; 

	//public GameObject temporaryBulletHandler;


	public float ForwardForce;

	// Use this for initialization
    void Start()
    {
        Cardboard.SDK.OnTrigger += TriggerPulled;

    
}
	
	// Update is called once per frame
	void Update () {

		//if (Input.GetKeyDown (KeyCode.Space)) {

		//	GameObject temporaryBulletHandler;

		//	temporaryBulletHandler = Instantiate (Bullet, BulletBarrel.transform.position, BulletBarrel.transform.rotation) as GameObject;

		//	temporaryBulletHandler.transform.Rotate (Vector3.left * 90); 

		//	Rigidbody temporaryRigidBody;
		//	temporaryRigidBody = temporaryBulletHandler.GetComponent<Rigidbody> ();

		//	temporaryRigidBody.AddForce (transform.forward * forwardForce);

		//	Destroy (temporaryBulletHandler, 3.0f);
		//}
}

    void OnEnable()
    {
        Cardboard.SDK.OnTrigger += TriggerPulled;
    }

    void OnDisable()
    {
        Cardboard.SDK.OnTrigger -= TriggerPulled;
    }

    void TriggerPulled()
    {
        var temporaryBulletHandler = Instantiate(Bullet, BulletBarrel.transform.position, BulletBarrel.transform.rotation) as GameObject;

        if (temporaryBulletHandler != null)
        {
            temporaryBulletHandler.transform.Rotate(Vector3.left * 90);

            var temporaryRigidBody = temporaryBulletHandler.GetComponent<Rigidbody>();

            temporaryRigidBody.AddForce(transform.forward * ForwardForce);

            Destroy(temporaryBulletHandler, 3.0f);
        }
    }




}