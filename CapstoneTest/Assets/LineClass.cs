using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using MyEnum;

// 전선의 양 끝단에 들어갈 클래스
public class LineClass : BaseClass
{
    private List<LineClass> lines = new List<LineClass>(); // 연결된 전선
    public ComponentClass component; //연결된 부품
    [SerializeField] private AttachClassForLineClass pair; // 전선의 짝

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
