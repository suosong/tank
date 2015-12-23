using UnityEngine;
using System.Collections;

public class player_control : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 euler = gameObject.transform.eulerAngles;
	    if (Input.GetKey(KeyCode.W))
        {
            euler.z = 0;
            gameObject.transform.eulerAngles = euler;
        }

        if (Input.GetKey(KeyCode.S))
        {
            euler.z = 180;
            gameObject.transform.eulerAngles = euler;
        }

        if (Input.GetKey(KeyCode.A))
        {
            euler.z = 90;
            gameObject.transform.eulerAngles = euler;
        }

        if (Input.GetKey(KeyCode.D))
        {
            euler.z = 270;
            gameObject.transform.eulerAngles = euler;
        }
	}
}
