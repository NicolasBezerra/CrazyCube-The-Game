using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AceleratorScript : MonoBehaviour 
{
    public GameObject[] AllBlocks1;
    public MainCubesPrefabs[] ReservePosition1;
    private CreatorBlocks MyCreator;
    public bool isPressed;
    private LevelControl Can;
    private Button MyButton;
    void Start () 
    {
        MyButton = GameObject.Find("Acelerator").GetComponent<Button>();
        MyCreator = GameObject.Find("Creator").GetComponent<CreatorBlocks>();
        isPressed = false;
        MyButton.interactable = false; 
	}
	void Update () 
    {
        if(Can == null)
        {
            Can = GameObject.Find("LevelController").GetComponent<LevelControl>();
        }
        ReservePosition1 = new MainCubesPrefabs[GameObject.FindGameObjectsWithTag("blocoMove").Length];
        if(Can.CanPlay)
        {
            MyButton.interactable = true;
        }
        try
        {
            AllBlocks1 = GameObject.FindGameObjectsWithTag("blocoMove");
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("blocoMove").Length; i++)
            {
                ReservePosition1[i] = GameObject.FindGameObjectsWithTag("blocoMove")[i].GetComponent<MainCubesPrefabs>();
            }
        }
        catch{}
        if (isPressed && Can.CanPlay)
        {
            try
            {
                for (int i = 0; i < AllBlocks1.Length; i++)
                {
                    AllBlocks1[i].transform.position = new Vector3(AllBlocks1[i].transform.position.x - 0.08f, AllBlocks1[i].transform.position.y, AllBlocks1[i].transform.position.z);
                }
            }
            catch { }
            for (int i = 0; i < ReservePosition1.Length; i++)
            {
                ReservePosition1[i].lastPosition = new Vector3(ReservePosition1[i].lastPosition.x - 0.08f, ReservePosition1[i].lastPosition.y, ReservePosition1[i].lastPosition.z);
            }
            MyCreator.Seconds += Time.deltaTime * 2f/1.5f;
        }
	}
    public void Up()
    {
        isPressed = false;
    }
    public void Down()
    {
        isPressed = true;
    }
}
