using UnityEngine;
using System.Collections;

public class Instanciador : MonoBehaviour {
	private Vector3 screenPoint;
	private GameObject bloco_pf;
	private Vector3 scanPos;
	private Vector3 lugar;
	private float tempo = 1;
	private float segundos;

	// Use this for initialization
	void Start () {
		screenPoint = Camera.main.WorldToScreenPoint(scanPos);

		lugar = Camera.main.ScreenToWorldPoint (new Vector3 (Camera.main.pixelWidth, Camera.main.pixelHeight/10f, screenPoint.z));
		bloco_pf = Resources.Load ("CubeAzul") as GameObject;
		//Instantiate (bloco_pf , lugar , Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		segundos = Time.realtimeSinceStartup;
		//Debug.Log (Time.realtimeSinceStartup);
		if(segundos > tempo)
		{
			Instantiate (bloco_pf , lugar , Quaternion.identity);
			tempo += 1f;
		}
	}
}
