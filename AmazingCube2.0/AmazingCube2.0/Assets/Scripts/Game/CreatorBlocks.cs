﻿using UnityEngine;
using System.Collections;

public class CreatorBlocks : MonoBehaviour 
{
	private Vector3 ScreenPoint;
	private GameObject bloco_a;
	private GameObject bloco_am;
	private GameObject bloco_v;
	private GameObject bloco_ve;
	private GameObject bloco_b;
	private GameObject bloco_l;
	private Vector3 lugar;
    private float TimeTo;
	public float Seconds;
	public Material Mycolor;
	public bool Catching;	
	private float CountTo;
	public bool coloca;
    private LevelControl Can;
	void Start () 
    {
        Catching = false;
        TimeTo = 1.7f;
        Seconds = 0;
		ScreenPoint = Camera.main.WorldToScreenPoint(new Vector3(0,0,0));
        lugar = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight/8, ScreenPoint.z));
		bloco_a = Resources.Load ("Prefabs/CubeAzul") as GameObject;
        bloco_am = Resources.Load("Prefabs/CubeAmarelo") as GameObject;
        bloco_v = Resources.Load("Prefabs/CubeVermelho") as GameObject;
        bloco_ve = Resources.Load("Prefabs/CubeVerde") as GameObject;
        bloco_b = Resources.Load("Prefabs/CubeBranco") as GameObject;
        bloco_l = Resources.Load("Prefabs/CubeLaranja") as GameObject;
	}
	
	void FixedUpdate () 
    {
        if(Can == null)
        {
            Can = GameObject.Find("LevelController").GetComponent<LevelControl>();
        }
        try
        {

            if (GameObject.FindGameObjectWithTag("blocoExit") != null)
            {
                CountTo += Time.deltaTime;
                if (CountTo > 0.002f)
                {
                    CountTo = 0;
                    Destroy(GameObject.FindGameObjectWithTag("blocoExit"));
                }
            }
            else if (coloca && Catching)
            {
                CountTo += Time.deltaTime;
                if (CountTo > 0.004f)
                {
                    coloca = false;
                    Catching = false;
                }
            }
        }
        catch
        {

        }
        if (Can.CanPlay)
        {
            Seconds += Time.deltaTime;
        }
        if (Seconds > TimeTo)
        {
            Seconds = 0;
            int RandomP = Mathf.FloorToInt(Random.Range(0, 6));
            switch (RandomP)
            {
                case 0:
                    Instantiate(bloco_a, lugar, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(bloco_am, lugar, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(bloco_v, lugar, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(bloco_ve, lugar, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(bloco_l, lugar, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(bloco_b, lugar, Quaternion.identity);
                    break;
            }
        }
	}
}
