using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGen : MonoBehaviour {

    // Use this for initialization
    public float max_x = 10.0f;
    public float min_x = 0.0f;
    public float max_y = 10.0f;
    public float min_y = 0.0f;

    void Start () {
        InvokeRepeating("new_pos",0,0.1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void new_pos()
    {
        float new_x = Random.Range(min_x, max_x);
        float new_y = Random.Range(min_y, max_y);
        transform.position = new Vector3(new_x, 0.0f, new_y);
    }

  //  void FixedUpdate(){
		//float temp = transform.position.x + 0.1f;
    //    transform.position = new Vector3(temp, 0.0f, 0.0f);
    //}
}
