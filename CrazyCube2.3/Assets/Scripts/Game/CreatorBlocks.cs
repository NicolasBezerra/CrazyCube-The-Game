using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CreatorBlocks : MonoBehaviour 
{
    private GameObject[] AllObjects;
	private Vector3 ScreenPoint;
	private GameObject bloco_a;
	private GameObject bloco_am;
	private GameObject bloco_v;
	private GameObject bloco_ve;
	private GameObject bloco_b;
	private GameObject bloco_l;
	private Vector3 lugar;
   	public float TimeTo;
	private float Seconds;
	public Material Mycolor;
	public bool Catching;	
	private float CountTo;
	public bool coloca;
    private bool CanInstantiate;
	void Start () 
    {
        CanInstantiate = true;
        Catching = false;
        TimeTo = 1.5f;
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
	
    void FixedUpdate()
    {
        try
        {
            AllObjects = GameObject.FindGameObjectsWithTag("blocoMove");
        }
        catch
        {

        }
        if (CanInstantiate)
        {
            Seconds += Time.deltaTime;
            if (Seconds > 2f)
            {
                Seconds = 0;
                CanInstantiate = false;
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
	void Update () 
    {
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
		
       
	}
    void OnTriggerEnter(Collider WithTag)
    {
        if(WithTag.gameObject.tag == "blocoMove")
        {
            CanInstantiate = true;
        }
    }

    public void Acelerating()
    {
        for(int i = 0; i < AllObjects.Length; i++)
        {
            AllObjects[i].transform.position = new Vector3(AllObjects[i].transform.position.x - 0.05f*3, AllObjects[i].transform.position.y, AllObjects[i].transform.position.z);
        }
        Seconds += Time.deltaTime*3;
    }
}
