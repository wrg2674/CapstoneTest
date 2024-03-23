using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyEnum;

public abstract class ComponentClass : BaseClass
{
    public AttachForComponentClass[] attach = new AttachForComponentClass[2]; // Inspector 창에서 지정해줘야함

    public abstract void Do();
    public override abstract void Receive();
    public override abstract void Give();
}
