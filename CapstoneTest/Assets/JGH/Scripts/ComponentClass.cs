using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyEnum;

public abstract class ComponentClass : BaseClass
{
    public AttachForComponentClass[] attach = new AttachForComponentClass[2]; // Inspector â���� �����������

    public abstract void Do();
    public override abstract void Receive();
    public override abstract void Give();
}
