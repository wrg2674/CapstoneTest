using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyEnum;
public class PowerClass : ComponentClass
{
    public override void Do()
    {
        
    }

    public override void Give()
    {
        int size = attach[(int)Direction.EXIT].link.Count;
        for(int i=0; i < size; i++)
        {
            attach[(int)Direction.EXIT].link[i].SetV(V);
            attach[(int)Direction.EXIT].link[i].Receive();
        }
    }

    public override void Receive()
    {
        
    }
}
