using UnityEngine;
using System.Collections;

public class MainCubeRotation : MonoBehaviour 
{
	public float sensitivityX ;
	public float sensitivityY ;
    private bool Down;
    private Touch MyTouch;
    public bool Touched;
    private AceleratorScript MVelS;
    private LevelControl Can;
	void Start ()
	{
        if(Application.platform == RuntimePlatform.Android)
        {
            MyTouch = Input.GetTouch(0);
        }
        Touched = false;
        Down = false;
		sensitivityX = 600.0f;
		sensitivityY = 600.0f;
	}
	void Update () 
    {
        if(Can == null)
        {
            Can = GameObject.Find("LevelController").GetComponent<LevelControl>();
        }
        if(MVelS == null)
        {
            MVelS = GameObject.Find("Acelerator").GetComponent<AceleratorScript>();
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            Touched = MyTouch.tapCount > 0 ? true : false;
        }
        if (!Down && !Touched && GameObject.FindGameObjectWithTag("blocoUsing") == null)
        {
            transform.Rotate(0.01f, 0.01f, 0.01f);
        }
		if(Input.GetMouseButtonDown(1))
        {
            Down = true;
        }	
		else if(Input.GetMouseButtonUp(1))
        {
            Down = false;
        }
        if (Can.CanPlay)
        {
            if (Application.platform == RuntimePlatform.Android && GameObject.FindGameObjectWithTag("blocoUsing") == null && MVelS.isPressed == false)
            {
                transform.Rotate(Input.GetTouch(0).deltaPosition.y * 400 / 10f * Time.deltaTime, Input.GetTouch(0).deltaPosition.x * - 400 / 10f * Time.deltaTime, 0f, Space.World);
                transform.Rotate(0f, 0f,((Input.GetTouch(1).deltaPosition.y * 400 / 10f * Time.deltaTime) + (Input.GetTouch(1).deltaPosition.x * -400 / 10f * Time.deltaTime))/2, Space.World);
            }
            else if (Down && GameObject.FindGameObjectWithTag("blocoUsing") == null && MVelS.isPressed == false)
            {
                transform.Rotate((Input.GetAxis("Mouse Y") * sensitivityY * Time.deltaTime), (Input.GetAxis("Mouse X") * -sensitivityX * Time.deltaTime), 0, Space.World);
            }
        }
	}
}
