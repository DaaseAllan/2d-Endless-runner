using UnityEngine;
using System.Collections;

public class Playercontrol : MonoBehaviour {
	private Rigidbody2D PlayerRig;
	private bool selvmord;
	// Use this for initialization
	void Start () {
		PlayerRig = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		//Movement ();
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (selvmord == false) {
				Movement ();
			}
			selvmord = true;
		}
		selvmord = false;
	}
	private void Movement(){
		PlayerRig.AddForce(Vector2.up*1000);
	}
}
