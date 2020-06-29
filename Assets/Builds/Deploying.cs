using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deploying : MonoBehaviour
{
    public GameObject GuideCursor;
    int? BuildId = null;
    public GameObject[] Buildings;
    List<GameObject> buildPos;
    public GameObject CurrentBuild;
    public Revenue income;
    public GenerateWorld generated;
    int index = 0;
    Tile[,] map;
    // Start is called before the first frame update
    private int getSize;
    void Start()
    {
        buildPos = new List<GameObject>();
        map = generated.getMap();
        Debug.LogWarning(map);
        getSize = generated.getSize;
        CurrentBuild = Buildings[0];
    }

    // Update is called once per frame
    void Update()
    {
        GuideCursor.GetComponent<SpriteRenderer>().sprite = CurrentBuild.GetComponent<SpriteRenderer>().sprite;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrentBuild = Buildings[0];
            index = 0;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrentBuild = Buildings[1];
            index = 1;

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CurrentBuild = Buildings[2];
            index = 2;

        }

        GuideCursor.transform.position = (Deploy());

        if (Input.GetMouseButtonDown(0) && !IsFull(Deploy()))
        {
            buildPos.Add((Instantiate(CurrentBuild,Deploy(),Quaternion.identity)));
            income.builds.Add(new Build(index));
        }
    }

    Vector2 MousePosOnWorld()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    Vector3 Deploy()
    {
        float x = Mathf.Floor(MousePosOnWorld().x) + .5f;

        float y = Mathf.Round(MousePosOnWorld().y / .6f) * .6f;
        y = y + .46f;
        if (Mathf.Abs(Mathf.Floor(MousePosOnWorld().y) - MousePosOnWorld().y) > .5 && Mathf.Abs(Mathf.Floor(MousePosOnWorld().x) - MousePosOnWorld().x) > .7)
        {

            x = x + .5f;
            y = y - 0.25f;
            Debug.Log("Code running");
        }
        if (Mathf.Abs(Mathf.Floor(MousePosOnWorld().y) - MousePosOnWorld().y) < .3 && Mathf.Abs(Mathf.Floor(MousePosOnWorld().x) - MousePosOnWorld().x) < .2)
        {
            x = x - .5f;
            y = y + 0.25f;

            Debug.Log("Code running");
        }
        Debug.Log("Y : " + y + "Mouse Y " + MousePosOnWorld().y);
        Debug.Log(Mathf.Abs(Mathf.Floor(MousePosOnWorld().y) - MousePosOnWorld().y));
        return new Vector3(x, y, y);
    }
    bool IsFull(Vector3 deploy)
    {
            bool temp = false;
            for(int i = 0;i < buildPos.Count;i++)
            {
                if (buildPos[i].transform.position == Deploy())
                {
                temp = true;
                break;
                
               
                }
            }
        
        return temp;
    }

}
