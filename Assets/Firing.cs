using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public Camera cam;
    public GameObject Arrow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           float degree =  Mathf.Rad2Deg * Mathf.Atan2(Diffrence().y,Diffrence().x);
            GameObject arrow =Instantiate(Arrow,transform.position,Quaternion.AngleAxis(degree,Vector3.forward));
            Rigidbody2D rb = arrow.AddComponent<Rigidbody2D>();
            rb.AddForce(arrow.transform.right * 250f);
            rb.gravityScale = 0;
            Debug.Log(degree);
        }
    }
    Vector3 MousePos()
    {
        return cam.ScreenToWorldPoint(Input.mousePosition) ;
    }
    Vector3 Diffrence()
    {
        return (MousePos() - transform.position);
    }
}
