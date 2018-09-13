using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("hi");

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
            this.GetComponent<ScreenRecorder>().CaptureScreenshot();
        }
    }
}
