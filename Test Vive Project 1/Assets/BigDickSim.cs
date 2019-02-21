using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDickSim : MonoBehaviour {

    public GameObject head;
    public float mult = 0.4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(head.transform.position.x + 0.214f, head.transform.position.y * mult, head.transform.position.z + -0.387f);
        transform.rotation = Quaternion.Euler(0, 180 + head.transform.localRotation.eulerAngles.y, 0);
	}
}
