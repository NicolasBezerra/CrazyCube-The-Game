using UnityEngine;
using System.Collections;

public class MasterRotationFuck : MonoBehaviour {

	public float sensitivityX ;
	public float sensitivityY ;
//	private Transform cameraTm;
	private float rotationVeriX;
	private float rotationX;
	private float rotationVeriY;
	private float rotationY;
	public bool down = false;
	
	// Use this for initializationz975
	void Start ()
	{
		sensitivityX = 300.0f;
		sensitivityY = 300.0f;
		//cameraTm = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetMouseButtonDown( 1 ) )
			down = true;
		else if( Input.GetMouseButtonUp( 1 ) )
			down = false;
		
		if(down){
			transform.Rotate((Input.GetAxis("Mouse Y") * sensitivityY * Time.deltaTime), (Input.GetAxis("Mouse X") * -sensitivityX * Time.deltaTime), 0, Space.World);/*
			rotationVeriX = rotationX;
			rotationX = Input.GetAxis("Mouse X") * sensitivityX;
			rotationVeriY = rotationY;
			rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
			if(rotationVeriX != rotationX)
			{
				//if(transform.localEulerAngles.y != 0)
				//{
					transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,transform.localEulerAngles.y,0);
				//}
				transform.RotateAround(cameraTm.up, -Mathf.Deg2Rad * rotationX);
			}
			if(rotationVeriY != rotationY)
			{
				//if(transform.localEulerAngles.x != 0)
				//{
				transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,transform.localEulerAngles.y,0f);
				//}
				transform.RotateAround(cameraTm.right, Mathf.Deg2Rad * rotationY/2);
			}*/
		}
		/*if (down) {
			float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
			transform.RotateAround( cameraTm.right, Mathf.Deg2Rad * rotationY );
		}*/
	}

}
