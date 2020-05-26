using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    float x = 1, y, z = 1;
    public GameObject groundGenerator;
    public int GridSize;
    // Start is called before the first frame update
    void Start()
    {
       for(int i = 0; i< GridSize; i++)
        {
            x += 1;
            z = 0;
            for (int j = 0 ;j < GridSize; j++){
                z += 1;
                GenerateGround(x,z);
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenerateGround(float x,float z)
    {
        Vector3 xDim = new Vector3();
        xDim.x = x;
        xDim.y = 0;
        xDim.z = z ;
        GameObject g = Instantiate(groundGenerator, xDim,Quaternion.identity);
    }
}
