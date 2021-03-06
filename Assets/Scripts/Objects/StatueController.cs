﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueController : MonoBehaviour {

	public PlayerController player;
	public GameObject umbrellaObject;

	// Use this for initialization
	void Start () {
			
	}

	// Update is called once per frame
	void Update () {
			
	}

	//opening door by contact with player while holding key
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player" && player.GetEquippedItem () == 2) {
			//animation for door goes here
			//destroy door as placeholder for now
			Animator animator = GetComponentInParent<Animator>();
			animator.SetTrigger("Open");
			player.SetEquippedItem (0);
			umbrellaObject.SetActive(true);

			StartCoroutine("FadeoutTimer");
		}
	}

	IEnumerator FadeoutTimer() {
        yield return new WaitForSeconds(1f);
        GetComponent<LevelLoadTrigger>().initiateLoad();
    }
}
