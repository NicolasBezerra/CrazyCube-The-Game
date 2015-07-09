using UnityEngine;
using System.Collections;

public class MainCubesPrefabs : MonoBehaviour 
{
	private Vector3 screenPoint ;
	private Vector3 curPosition;
	private Vector3 scanPos;
	private Vector3 offset;
	private GameObject eu;
	private CreatorBlocks CatchColor;
    private int R1;
    private int R2;
    private int R3;
	void Start()
	{
        R1 = Mathf.FloorToInt(Random.Range(-1, 2));
        R2 = Mathf.FloorToInt(Random.Range(-1, 2));
        R3 = Mathf.FloorToInt(Random.Range(-1, 2));
        if (R1 == 0)
        {
            R1 = 1;
        }
        if (R2 == 0)
        {
            R2 = -1;
        }
        if (R3 == 0)
        {
            R3 = 1;
        }
		CatchColor = GameObject.Find("Creator").GetComponent<CreatorBlocks>();
	}
	void Update ()
    {
        transform.Rotate(R1, R2, R3);
        if (gameObject.tag.Equals("blocoMove"))
        {
            transform.position = new Vector3(transform.position.x - 0.05f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -11)
        {
            Destroy(gameObject);
        }
		scanPos = transform.position;
		transform.position = new Vector3 (transform.position.x,transform.position.y, transform.position.z);
	}
	void OnMouseDown() 
    { 
		screenPoint = Camera.main.WorldToScreenPoint(scanPos);
		offset = scanPos - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}
	void OnMouseDrag() {
		CatchColor.Catching = true;
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		transform.position = curPosition;
		transform.gameObject.tag = "blocoUsing";
        if(GameObject.FindGameObjectWithTag("blocoUsing").transform.localScale != new Vector3(1,1,1))
        {
            GameObject.FindGameObjectWithTag("blocoUsing").transform.localScale = new Vector3(1, 1, 1);
        }
	}
	void OnMouseUp() 
	{
		CatchColor.Mycolor = gameObject.renderer.material;
		CatchColor.coloca = true;
	    transform.gameObject.tag = "blocoExit";
	}
}


