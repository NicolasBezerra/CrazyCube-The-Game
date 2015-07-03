using UnityEngine;
using System.Collections;

public class ColorDefault : MonoBehaviour 
{
	public GameObject[] Faces;
	private float CountTo;
	public bool CanColor;
	public FaceScript ColorId;
	private int counter;
	private int loving;
	private bool ContinueTry;
	private bool[] amorzinho;
	
	void Start () 
	{
		//amorzinho = new bool[54];
		counter = 0;
		ContinueTry = true;
		CanColor = true;
		try 
		{
			for (int i = 0; i < 54; i++) 
			{
				Faces [i].renderer.material = Resources.Load ("CubeDefault", typeof(Material)) as Material;
			}
		} 
		catch 
		{

		}
	
	}
	
	void Update () 
	{
		if(gameObject.name == "MiniCube")
		{
			GameObject.Find("MiniCube").transform.Rotate(1,1,1);
		}
		if(gameObject.name == "MiniCube" && CanColor)
		{
			while(counter < 54)
			{
				ColorId = Faces[counter].GetComponent<FaceScript>();
				ColorId.ActualColor = Mathf.FloorToInt(Random.Range(1,5));
				counter += 1;
			}
			if(counter >= 53)
			{
				CanColor = false;
			}
		}
		CountTo += Time.deltaTime;
		if(gameObject.name == "CubeM")
		{

			FaceScript baby;
			baby = gameObject.GetComponent<FaceScript>();
			if(CountTo > 10f)
			{
				CountTo = 0;
				try
				{
					Faces[Random.Range(0,54)].renderer.material = Resources.Load("CubeDefault", typeof(Material)) as Material;
				}
				catch
				{

				}
			}
			while(loving < 54)
			{
				if(VerifyColors(loving, baby))
				{
					amorzinho[loving] = true;
				}
				loving ++;
				for(int i = 0; i < 54; i++)
				{
					if(amorzinho[i])
					{
						ContinueTry = false;
					}
				}
				if(loving >= 53 && ContinueTry)
				{
					loving = 0;
				}
			}
		}
	}
	void ChangingColors(FaceScript lol)
	{
		lol.ActualColor = Mathf.FloorToInt(Random.Range(1,5));	
	}	
	bool VerifyColors(int i, FaceScript lol)
	{
		lol = Faces[i].GetComponent<FaceScript>();
		if(lol.ActualColor == ColorId.ActualColor)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
