using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		float temp = transform.position.x + 0.1f;
        transform.position = new Vector3(temp,  0.0f, 0.0f);
    }
}
