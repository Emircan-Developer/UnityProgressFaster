using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    int x, y;
    private int width, height;
    private int[,] GridList;
    public Grid(int width,int height,GameObject Frame)
    {
        this.height = height;
        this.width = width;

        GridList = new int[width,height];

        for(int i = 0; i< GridList.GetLength(0); i++)
        {
            for(int j = 0;j< GridList.GetLength(1); j++)
            {
           
                x = i * 1;
                y = j * 1;
                GameObject newFrame = GameObject.Instantiate(Frame);
                newFrame.transform.position = new Vector2(x, y);
            }
        }
    }
}
