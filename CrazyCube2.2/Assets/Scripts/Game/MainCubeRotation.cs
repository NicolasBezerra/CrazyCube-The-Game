using UnityEngine;
using System.Collections;

public class MainCubeRotation : MonoBehaviour 
{
	public float sensitivityX ;
	public float sensitivityY ;
    private bool Down;
	void Start ()
	{
        Down = false;
		sensitivityX = 300.0f;
		sensitivityY = 300.0f;
	}
	void Update () 
    {
		if(Input.GetMouseButtonDown(1))
        {
            Down = true;
        }	
		else if(Input.GetMouseButtonUp(1))
        {
            Down = false;
        }

        if (Application.platform == RuntimePlatform.Android)
        {
            transform.Rotate((Input.GetTouch(0).deltaPosition.y * sensitivityY/10 * Time.deltaTime), 0, 0, Space.World);
            transform.Rotate(0, (Input.GetTouch(1).deltaPosition.x * -sensitivityX / 10 * Time.deltaTime), 0, Space.World);
        }
        if (Down && Application.platform == RuntimePlatform.WindowsPlayer || Down && Application.platform == RuntimePlatform.WindowsEditor)
        {
            transform.Rotate((Input.GetAxis("Mouse Y") * sensitivityY * Time.deltaTime), (Input.GetAxis("Mouse X") * -sensitivityX * Time.deltaTime), 0, Space.World);
		}
	}
}
