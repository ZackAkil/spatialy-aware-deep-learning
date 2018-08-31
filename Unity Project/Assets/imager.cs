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
        print("hi");
        Texture2D something = RTImage(GetComponent<Camera>());
        //print(something);
		
	}

    Texture2D RTImage(Camera cam)
    {
        RenderTexture currentRT = RenderTexture.active;
        RenderTexture.active = cam.targetTexture;
        cam.Render();
        print(cam.targetTexture.width);
        Texture2D image = new Texture2D(cam.targetTexture.width, cam.targetTexture.height);
        image.ReadPixels(new Rect(0, 0, cam.targetTexture.width, cam.targetTexture.height), 0, 0);
        image.Apply();
        RenderTexture.active = currentRT;
        return image;
    }
}
