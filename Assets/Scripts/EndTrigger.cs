using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(other.tag.Equals("end")){
			other.GetComponent<StartSparks> ().Go ();
		}
	}
}
