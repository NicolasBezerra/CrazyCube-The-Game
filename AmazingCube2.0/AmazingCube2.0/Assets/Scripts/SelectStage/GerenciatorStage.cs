using UnityEngine;
using System.Collections;

public class GerenciatorStage : MonoBehaviour 
{
    public GameObject[] Stages;
    private GameObject Locker;
    public GameObject[] MyLock;
	void Start () 
    {
      /*PlayerPrefs.SetInt("Level", 0);*/
      /*PlayerPrefs.SetInt("LevelMax", 0);
      PlayerPrefs.SetInt("LevelMaxx", 0);
      PlayerPrefs.SetInt("LevelMaxxx", 0);
      PlayerPrefs.SetInt("LevelMaxxxx", 0);
      PlayerPrefs.SetInt("LevelMaxxxxx", 0);
      PlayerPrefs.SetInt("LevelMaxxxxxx", 0);
      PlayerPrefs.SetInt("LevelMaxxxxxxx", 0);
      PlayerPrefs.SetInt("LevelMaxxxxxxxx", 0);
      PlayerPrefs.SetInt("LevelMaxxxxxxxxx", 0);
      for (int i = 0; i < 6; i++ )
      {
          PlayerPrefs.SetInt("Points"+i, 0);
          PlayerPrefs.SetInt("Pointss" + i, 0);
          PlayerPrefs.SetInt("Pointsss" + i, 0);
          PlayerPrefs.SetInt("Pointssss" + i, 0);
          PlayerPrefs.SetInt("Pointsssss" + i, 0);
          PlayerPrefs.SetInt("Pointssssss" + i, 0);
          PlayerPrefs.SetInt("Pointsssssss" + i, 0);
          PlayerPrefs.SetInt("Pointssssssss" + i, 0);
          PlayerPrefs.SetInt("Pointsssssssss" + i, 0);
      }
           */
      /*for (int i = 0; i < 6; i++ )
      {
         PlayerPrefs.SetInt("Points"+i, 0);
      }*/
          
        MyLock = new GameObject[6];
        Locker = Resources.Load("Prefabs/Locker",typeof(GameObject)) as GameObject;
        try
        {
            switch(Application.loadedLevel)
            {
                case 3:
                    for (int i = 0; i < Stages.Length; i++)
                    {
                        Stages[i].name = "" + (i + 1);
                    }
                    break;
                case 8:
                    for (int i = 0; i < Stages.Length; i++)
                    {
                        Stages[i].name = "" + (i + 7);
                    }
                    break;
                case 9:
                    for (int i = 0; i < Stages.Length; i++)
                    {
                        Stages[i].name = "" + (i + (7*2) - 1);
                    }
                    break;
                case 10:
                    for (int i = 0; i < Stages.Length; i++)
                    {
                        Stages[i].name = "" + (i + (7 * 3) - 2);
                    }
                    break;
                case 11:
                    for (int i = 0; i < Stages.Length; i++)
                    {
                        Stages[i].name = "" + (i + (7 * 4) - 3);
                    }
                    break;
                case 12:
                    for (int i = 0; i < Stages.Length; i++)
                    {
                        Stages[i].name = "" + (i + (7 * 5) - 4);
                    }
                    break;
                case 13:
                    for (int i = 0; i < Stages.Length; i++)
                    {
                        Stages[i].name = "" + (i + (7 * 6) - 5);
                    }
                    break;
                case 14:
                    for (int i = 0; i < Stages.Length; i++)
                    {
                        Stages[i].name = "" + (i + (7 * 7) - 6);
                    }
                    break;
                case 15:
                    for (int i = 0; i < Stages.Length; i++)
                    {
                        Stages[i].name = "" + (i + (7 * 8) - 7);
                    }
                    break;
            }
        }
        catch { }
        for (int i = 0; i < Stages.Length + 1; i++ )
        {
            int What;
            What = i;
            switch(Application.loadedLevel)
            {
                case 3:
                    if (PlayerPrefs.GetInt("LevelMax") < i)
                    {
                        if (i < 4)
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), Locker.transform.position.y, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 15.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -10.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    else if (i != 0)
                    {
                        if (i < 4)
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 17f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    break;
                case 8:
                    if (PlayerPrefs.GetInt("LevelMaxx") < i)
                    {
                        if (i < 4)
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), Locker.transform.position.y, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + 6), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 15.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + 6), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -10.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    else if (i != 0)
                    {
                        if (i < 4)
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + 6), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 17f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + 6), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    break;
                case 9:
                    if (PlayerPrefs.GetInt("LevelMaxxx") < i)
                    {
                        if (i < 4)
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), Locker.transform.position.y, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 2)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 15.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 2)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -10.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    else if (i != 0)
                    {
                        if (i < 4)
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 2)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 17f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 2)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    break;
                case 10:
                    if (PlayerPrefs.GetInt("LevelMaxxxx") < i)
                    {
                        if (i < 4)
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), Locker.transform.position.y, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 3)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 15.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 3)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -10.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    else if (i != 0)
                    {
                        if (i < 4)
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 3)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 17f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 3)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    break;
                case 11:
                    if (PlayerPrefs.GetInt("LevelMaxxxxx") < i)
                    {
                        if (i < 4)
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), Locker.transform.position.y, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 4)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 15.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 4)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -10.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    else if (i != 0)
                    {
                        if (i < 4)
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 4)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 17f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6*4)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    break;
                case 12:
                    if (PlayerPrefs.GetInt("LevelMaxxxxxx") < i)
                    {
                        if (i < 4)
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), Locker.transform.position.y, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6*5)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 15.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6*5)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -10.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    else if (i != 0)
                    {
                        if (i < 4)
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 5)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 17f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 5)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    break;
                case 13:
                    if (PlayerPrefs.GetInt("LevelMaxxxxxxx") < i)
                    {
                        if (i < 4)
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), Locker.transform.position.y, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 6)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 15.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 6)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -10.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    else if (i != 0)
                    {
                        if (i < 4)
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 6)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 17f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 6)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    break;
                case 14:
                    if (PlayerPrefs.GetInt("LevelMaxxxxxxxx") < i)
                    {
                        if (i < 4)
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), Locker.transform.position.y, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 7)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 15.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 7)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -10.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    else if (i != 0)
                    {
                        if (i < 4)
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 7)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 17f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 7)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    break;
                case 15:
                    if (PlayerPrefs.GetInt("LevelMaxxxxxxxxx") < i)
                    {
                        if (i < 4)
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), Locker.transform.position.y, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 8)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 15.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            MyLock[i - 1] = Instantiate(Locker, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z), Quaternion.identity) as GameObject;
                            Instantiate(Resources.Load("Prefabs/NumbersBlack/Numerais_Preto_" + (i + (6 * 8)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -10.5f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    else if (i != 0)
                    {
                        if (i < 4)
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 8)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 1f) * 40f), 17f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                        else
                        {
                            Instantiate(Resources.Load("Prefabs/NumbersWhite/Numerais_Branco_" + (i + (6 * 8)), typeof(GameObject)) as GameObject, new Vector3(Locker.transform.position.x + ((i - 4f) * 40f), -9f, Locker.transform.position.z - 1f), Quaternion.identity);
                        }
                    }
                    break;
            }
        }
        for(int i = 0; i < MyLock.Length; i++)
        {
            if (Application.loadedLevel == 3)
            {
                if (MyLock[i] != null)
                {
                    MyLock[i].name = "L" + (i + 1);
                }
            }
            else if (Application.loadedLevel == 8)
            {
                if (MyLock[i] != null)
                {
                    MyLock[i].name = "L" + (i + 7);
                }
            }
            else if (Application.loadedLevel == 9)
            {
                if (MyLock[i] != null)
                {
                    MyLock[i].name = "L" + (i + 13);
                }
            }
            else if (Application.loadedLevel == 10)
            {
                if (MyLock[i] != null)
                {
                    MyLock[i].name = "L" + (i + 19);
                }
            }
            else if (Application.loadedLevel == 11)
            {
                if (MyLock[i] != null)
                {
                    MyLock[i].name = "L" + (i + 25);
                }
            }
            else if (Application.loadedLevel == 12)
            {
                if (MyLock[i] != null)
                {
                    MyLock[i].name = "L" + (i + 31);
                }
            }
            else if (Application.loadedLevel == 13)
            {
                if (MyLock[i] != null)
                {
                    MyLock[i].name = "L" + (i + 37);
                }
            }
            else if (Application.loadedLevel == 14)
            {
                if (MyLock[i] != null)
                {
                    MyLock[i].name = "L" + (i + 43);
                }
            }
            else if (Application.loadedLevel == 15)
            {
                if (MyLock[i] != null)
                {
                    MyLock[i].name = "L" + (i + 49);
                }
            }
        }
	}
	void Update () 
    {
	    
    }
}
