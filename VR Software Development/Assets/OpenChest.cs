using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {


    private bool open = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    //void Update()
    //{
    //    if (open)
    //    {
    //        transform.Translate(Vector3.forward * Time.deltaTime);
    //        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    //    }
    //}


    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;
    void Update()
    {
        if (open)
        {
            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
            Quaternion target = Quaternion.Euler(tiltAroundZ, 0, tiltAroundX);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
    }



    public void Open()
    {
        Debug.Log("OpenChest has been called.");
        open = true;
    }
}
