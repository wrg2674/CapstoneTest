using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using MyEnum;

// ������ �� ���ܿ� �� Ŭ����
public class LineClass : BaseClass
{
    private List<LineClass> lines = new List<LineClass>(); // ����� ����
    public ComponentClass component; //����� ��ǰ
    [SerializeField] private AttachClassForLineClass pair; // ������ ¦

    private int linkCount = 0;
    public bool isParallel = false;

    private void setIsParallel()
    {
        if(linkCount > 1) {
            isParallel = true;
        }
        else
        {
            isParallel = false;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.GetComponent<LineClass>())
        {
            lines.Add(obj.GetComponent<LineClass>());
            linkCount++;
            setIsParallel();
        }
        if (obj.GetComponent<ComponentClass>())
        {
            component = obj.GetComponent<ComponentClass>();
        }

    }
    public void OnTriggerExit(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.GetComponent<LineClass>())
        {
            lines.Remove(obj.GetComponent<LineClass>());
            linkCount--;
            setIsParallel();
        }
        if (obj.GetComponent<ComponentClass>())
        {
            component = obj.GetComponent<ComponentClass>();
        }
    }
    public override void Receive()
    {
        
    }
    public override void Give()
    {
        
    }
}
