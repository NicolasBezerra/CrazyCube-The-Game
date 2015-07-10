using UnityEngine;
using System.Collections;

public class MatScript : MonoBehaviour 
{
    private GameObject[] NotUsed;
	void Start () 
    {
        try
        {
            NotUsed = GameObject.FindGameObjectsWithTag("blocoMove");
        }
        catch
        {

        }
	}
	
	void Update () 
    {
        try
        {
            NotUsed = GameObject.FindGameObjectsWithTag("blocoMove");
        }
        catch
        {

        }
        for (int i = 0; i < NotUsed.Length; i++)
        {
            if (Input.GetMouseButtonDown(0) && Input.GetAxis("Mouse X")*Time.deltaTime < 0)
            {
                NotUsed[i].transform.position = new Vector3(NotUsed[i].transform.position.x - 0.1f, NotUsed[i].transform.position.y, NotUsed[i].transform.position.z);
            }
        } 
	}
}
