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
        if (Down && Application.platform == RuntimePlatform.WindowsPlayer || Down && Application.platform == RuntimePlatform.WindowsEditor)
        {
            if(GameObject.FindGameObjectWithTag("blocoUsing") == null)
            {
                transform.Rotate((Input.GetAxis("Mouse Y") * sensitivityY * Time.deltaTime), (Input.GetAxis("Mouse X") * -sensitivityX * Time.deltaTime), 0, Space.World);
            }
		}
        else if (Application.platform == RuntimePlatform.Android)
        {
            if (GameObject.FindGameObjectWithTag("blocoUsing") == null)
            {
                transform.Rotate((Input.GetTouch(0).deltaPosition.y * sensitivityY / 10 * Time.deltaTime), (Input.GetTouch(0).deltaPosition.x * -sensitivityX / 10 * Time.deltaTime), 0, Space.World);
                transform.Rotate(0, 0, ((Input.GetTouch(1).deltaPosition.x * -sensitivityX / 10 * Time.deltaTime) + (Input.GetTouch(1).deltaPosition.y * -sensitivityY / 10 * Time.deltaTime)) / 2, Space.World);
            }
        }
        if(Down == false || Input.GetMouseButton(0) == false || Input.GetMouseButtonDown(0) == false)
        {
            transform.Rotate(0.01f, 0.01f, 0.01f);
        }
	}
}
