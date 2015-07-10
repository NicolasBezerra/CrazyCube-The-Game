using UnityEngine;
using System.Collections;

public class LevelControl : MonoBehaviour 
{
    public int Level;
    private int CounterToPrint;
    private ColorDefault FacesBig;
    private ColorDefault FacesMini;
    private int MyRandom;
	void Start () 
    {
        DontDestroyOnLoad(gameObject);
        MyRandom = Mathf.FloorToInt(Random.Range(0, 54));
        FacesBig = GameObject.Find("CubeM").GetComponent<ColorDefault>();
        FacesMini = GameObject.Find("MiniCube").GetComponent<ColorDefault>();
        CounterToPrint = 0;
	}
	
	void Update () 
    {
        if (CounterToPrint < 54 - Level)
        {
            if (FacesBig.Faces[MyRandom].renderer.material.mainTexture == FacesMini.Faces[MyRandom].renderer.material.mainTexture)
            {
                MyRandom = Mathf.FloorToInt(Random.Range(0, 54));
            }
            else
            {
                FacesBig.Faces[MyRandom].renderer.material = FacesMini.Faces[MyRandom].renderer.material;
                CounterToPrint++;
            }
        }
	}
}
