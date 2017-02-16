using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSparks : MonoBehaviour {

	public GameObject sparks;
	public GameObject text;

	public void Go(){
		Instantiate (sparks, transform.position, Quaternion.identity);
		text.GetComponent<Text>().text = "The End";
	}
}
