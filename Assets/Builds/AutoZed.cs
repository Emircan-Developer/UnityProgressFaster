using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoZed : MonoBehaviour
{
    [SerializeField]
    private GameObject self;
    public float StockZed = 0;
    public float newZed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        newZed = self.transform.position.y;
        StockZed = self.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        newZed =  self.transform.position.y;
        if(StockZed != newZed){
            StockZed = newZed;
            self.transform.position = new Vector3(self.transform.position.x,self.transform.position.y,StockZed);
        }
    }
}
