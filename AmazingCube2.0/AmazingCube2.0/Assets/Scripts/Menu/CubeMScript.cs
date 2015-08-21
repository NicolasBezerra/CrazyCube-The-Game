using UnityEngine;
using System.Collections;

public class CubeMScript : MonoBehaviour 
{
    public int color;
	void Awake () 
    {
        if(gameObject.name == "CubeM")
        {
            color = Mathf.FloorToInt(Random.Range(0, 6));
        }
        else
        {
            color = Mathf.FloorToInt(Random.Range(1, 5));
        }
	}
	void Update () 
    {
        if(gameObject.name == "CubeM")
        {
            transform.Rotate(0.5f, 1.5f, 0.5f);
        }
	}
}
