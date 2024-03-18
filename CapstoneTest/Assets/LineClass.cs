using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineClass : ComponentClass
{
    public override void Do()
    {
        
    }
    public override void Receive()
    {
        int size = attach[(int)(Direction.ENTER)].link.Count;
        for (int i = 0; i < size; i++)
        {
            I += attach[(int)(Direction.ENTER)].link[i].GetComponent<LineClass>().GetI();
        }
        V = I * R;
    }
}
