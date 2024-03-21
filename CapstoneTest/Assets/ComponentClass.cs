using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyEnum;

public abstract class ComponentClass : BaseClass
{
    public AttachForComponentClass[] attach = new AttachForComponentClass[2]; // Inspector â���� �����������

    public abstract void Do();
    public override void Receive()
    {
        int size = attach[(int)(Direction.ENTER)].link.Count;
        for(int i=0; i < size; i++)
        {
            I += attach[(int)(Direction.ENTER)].link[i].GetComponent<LineClass>().GetI();
        }
        I = I / R;
    }
    public override void Give()
    {
        

    }
}
