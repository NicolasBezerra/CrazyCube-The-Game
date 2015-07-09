﻿using UnityEngine;
using System.Collections;

public class ColorDefault : MonoBehaviour 
{
    public GameObject[] Faces;
    private FaceScript ColorId;
	private float CountTo;
	private bool CanColor;
	private int Counter;
	void Start () 
	{
       
		Counter = 0;
		CanColor = true;
		try 
		{
			for (int i = 0; i < 54; i++) 
			{
				Faces [i].renderer.material = Resources.Load ("Materials/CubeDefault", typeof(Material)) as Material;
			}
		} 
		catch 
		{

		}
	}
	void Update () 
	{
		GameObject.Find("MiniCube").transform.Rotate(0.5f,0.5f,0.5f);
		if(gameObject.name == "MiniCube" && CanColor)
		{
			while(Counter < 54)
			{
				ColorId = Faces[Counter].GetComponent<FaceScript>();
				ColorId.ActualColor = Mathf.FloorToInt(Random.Range(1,7));
				Counter += 1;
			}
			if(Counter >= 53)
			{
				CanColor = false;
			}
		}
		CountTo += Time.deltaTime;
		if(gameObject.name == "CubeM")
		{
            if (CountTo > 60f)
            {
                CountTo = 0;
                try
                {
                    Faces[Random.Range(0, 54)].renderer.material = Resources.Load("Materials/CubeDefault", typeof(Material)) as Material;
                }
                catch
                {

                }
            }
		}
	}
	void ChangingColors(FaceScript facesS)
	{
		facesS.ActualColor = Mathf.FloorToInt(Random.Range(1,5));	
	}	
}
