using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	void Update () {
		transform.Rotate (new Vector3 (13, 30, 45) * Time.deltaTime);
	}
}
