using UnityEngine;
using System.Collections;

public class Instanciador : MonoBehaviour {
	private Vector3 screenPoint;
	private GameObject bloco_a;
	private GameObject bloco_am;
	private GameObject bloco_v;
	private GameObject bloco_ve;
	private Vector3 lugar;
	private float tempo = 1;
	private float segundos;
	public Color Mycolor;
	public bool Catching = false;	
	private int myInt;
	public float CountTo;
	public bool coloca;
	
	// Use this for initialization
	void Start () {
		screenPoint = Camera.main.WorldToScreenPoint(new Vector3(0,0,0));

		lugar = Camera.main.ScreenToWorldPoint (new Vector3 (Camera.main.pixelWidth, Camera.main.pixelHeight/10f, screenPoint.z));
		bloco_a = Resources.Load ("CubeAzul") as GameObject;
		bloco_am = Resources.Load ("CubeAmarelo") as GameObject;
		bloco_v = Resources.Load ("CubeVermelho") as GameObject;
		bloco_ve = Resources.Load ("CubeVerde") as GameObject;
		//Instantiate (bloco_pf , lugar , Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		try
		{
			if(GameObject.FindGameObjectWithTag("blocoExit")!= null)
			{
				CountTo += Time.deltaTime;
				if(CountTo > 0.002f)
				{
					CountTo = 0;
					Destroy(GameObject.FindGameObjectWithTag("blocoExit") );
				}
			}
			else if(coloca && Catching)
			{
				CountTo += Time.deltaTime;
				if(CountTo > 0.004f)
				{
					coloca = false;
					Catching = false;
				}
			}
		}
		catch
		{
			
		}
		segundos = Time.realtimeSinceStartup;
		//Debug.Log (Time.realtimeSinceStartup);
		if(segundos > tempo)
		{
			myInt = Mathf.FloorToInt(Random.Range(0,4));
			switch(myInt)
			{
				case 0:
					Instantiate (bloco_a , lugar , Quaternion.identity);
				break;
				case 1:
					Instantiate (bloco_am , lugar , Quaternion.identity);
				break;
				case 2:
					Instantiate (bloco_v , lugar , Quaternion.identity);
				break;
				case 3:
					Instantiate (bloco_ve , lugar , Quaternion.identity);
				break;
			}
			tempo += 1f;
		}
		
	}
}
