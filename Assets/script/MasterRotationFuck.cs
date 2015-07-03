using UnityEngine;
using System.Collections;

public class MasterRotationFuck : MonoBehaviour {

	public float sensitivityX ;
	public float sensitivityY ;
	private Transform cameraTm;
	private float rotationVeriX;
	private float rotationX;
	private float rotationVeriY;
	private float rotationY;
	public bool down = false;
	
	// Use this for initializationz975
	void Start ()
	{
		sensitivityX = 10.0f;
		sensitivityY = 10.0f;
		cameraTm = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetMouseButtonDown( 1 ) )
			down = true;
		else if( Input.GetMouseButtonUp( 1 ) )
			down = false;
		
		if(down){
			rotationVeriX = rotationX;
			rotationX = Input.GetAxis("Mouse X") * sensitivityX;
			rotationVeriY = rotationY;
			rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
			if(rotationVeriX != rotationX)
			{
				if(transform.localEulerAngles.y != 0)
				{
					transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,transform.localEulerAngles.y,0);
				}
				transform.RotateAround(cameraTm.up, -Mathf.Deg2Rad * rotationX);
			}
			else if(rotationVeriY != rotationY)
			{
				if(transform.localEulerAngles.x != 0)
				{
					transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,transform.localEulerAngles.y,0);
				}
				transform.RotateAround(cameraTm.right, Mathf.Deg2Rad * rotationY);
			}
		}
		/*if (down) {
			float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
			transform.RotateAround( cameraTm.right, Mathf.Deg2Rad * rotationY );
		}*/
	}

}
