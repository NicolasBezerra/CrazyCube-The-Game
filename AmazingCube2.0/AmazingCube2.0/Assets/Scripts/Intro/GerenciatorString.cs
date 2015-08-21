using UnityEngine;
using System.Collections;
public class GerenciatorString : MonoBehaviour 
{
	public int j;
    public GameObject[] Setas;
	void Start () 
	{
		j = 0;   
	}
	void Update () 
	{
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("Sprites/Instrucoes_Interativas-" + j, typeof(Sprite)) as Sprite;
        switch (j)
        {
            case 0:
                Setas[3].SetActive(false);
                Setas[0].SetActive(true);
                Setas[1].SetActive(false);
                break;
            case 1:
                Setas[0].SetActive(false);
                Setas[1].SetActive(true);
                Setas[2].SetActive(false);
                break;
            case 2:
                Setas[1].SetActive(false);
                Setas[2].SetActive(true);
                Setas[3].SetActive(false);
                break;
            case 3:
                Setas[2].SetActive(false);
                Setas[3].SetActive(true);
                Setas[0].SetActive(false);
                break;
        }
	}
	
}
