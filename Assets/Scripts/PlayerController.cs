using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public float speed = 10;
	private int count;
	public Text text;
	public Text winText;

	void Start(){
		count = 0;
		setCountText ();
		winText.text = "";
	}


	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive (false);		
			count++;
			setCountText();
		}
	}

	void setCountText ()
	{
		text.text = "Count: " + count.ToString ();
		if (count >= 12) {
				winText.text = "You are winner!";
		}
	}
}
