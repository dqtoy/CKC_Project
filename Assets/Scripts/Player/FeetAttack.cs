using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetAttack : MonoBehaviour {

	public PlayerController player;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy") {
			player.Jump ();
			Destroy (other.gameObject);

			// Make smoke effect
			BellController bell = other.gameObject.GetComponent<BellController> ();
			bell.MakeSmoke ();
		} 
		else if (other.gameObject.tag == "Cloud") {
			player.Jump ();
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Enemy") {
			player.Jump();
			Destroy(other.gameObject);

			// Make smoke effect
			BellController bell = other.gameObject.GetComponent<BellController>();
			bell.MakeSmoke();
		}
		else if (other.gameObject.tag == "Cloud") {
			player.Jump ();
		}
	}
}