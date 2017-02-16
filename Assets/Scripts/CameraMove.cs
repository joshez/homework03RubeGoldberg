using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public Vector3 first;
	public Vector3 firstR;
	public Vector3 second;
	public Vector3 secondR;
	public Vector3 third;
	public Vector3 thirdR;
	public Vector3 fourth;
	public Vector3 fourthR;
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Time.timeSinceLevelLoad < 15f) {
			transform.Translate (first);
			transform.Rotate (firstR);
//		} if ((Time.time < 20) && (Time.time > 15)) {
//			transform.Translate (second);
//			transform.Rotate (secondR);
//		} if ((Time.time < 30) && (Time.time > 20)) {
//			transform.Translate (third);
//			transform.Rotate (thirdR);
//		} if ((Time.time < 40) && (Time.time > 30)) {
//			transform.Translate (fourth);
//			transform.Rotate (fourthR);
		} if ((Time.timeSinceLevelLoad > 15f) && (Time.timeSinceLevelLoad < 21f)) {
			transform.position = new Vector3 (-16.15f, 6.16f, 8.33f);
			transform.rotation = Quaternion.Euler (15.67f, 191.419f, 5.281f);
		} if ((Time.timeSinceLevelLoad > 21f) && (Time.timeSinceLevelLoad < 30f)){
			transform.position = new Vector3 (-46.73f, 7.53f, -5.33f);
			transform.rotation = Quaternion.Euler (23.629f, 104.749f, -3.71f);
		} if (Time.timeSinceLevelLoad > 29f) {
			transform.position = new Vector3 (-39.63f, -13.78f, -12.81f);
			transform.rotation = Quaternion.Euler (26.397f, 147.068f, 5.892f);
		}
	}
}
