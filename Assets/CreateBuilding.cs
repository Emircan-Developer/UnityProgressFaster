using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateBuilding : MonoBehaviour
{
    public GameObject ground;
    static CreateBuilding c;
    public GameObject item;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        c = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(mousePos() != Vector3.zero)
            {
                GridFixer(mousePos().x, mousePos().y, mousePos().z);
                return;
            }
            Debug.Log(mousePos());
        }
    }
    static Vector3 mousePos()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit2d;
            if(Physics.Raycast(ray,out rayHit2d))
            {
                if (rayHit2d.collider.tag != "Build" || rayHit2d.collider.tag != "Campfire")
                {
                    return rayHit2d.point;
                }
                else
                {
                    c.SendException();
                    Debug.Log("Error");

                }
            }
        }
        return Vector3.zero;
    }
    void SendException()
    {
        GameException.Building(text);

    }
    Vector3 posFixer;
    public float gridSize;
    void GridFixer(float x,float y,float z)
    {
        posFixer.x = Mathf.Floor(x / gridSize) * gridSize;
        posFixer.y = y;
        posFixer.z = Mathf.Floor(z / gridSize) * gridSize;

        Instantiate(item, posFixer, Quaternion.identity);

    }
}
