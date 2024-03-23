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
    [SerializeField] private LineClass pair; // 전선의 짝

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
            LineClass line = obj.GetComponent<LineClass>();
            lines.Add(line);
            linkCount++;
            setIsParallel();
            if (isParallel)
            {

            }
            else
            {
                SetR(R + line.GetR());
                SetV(V + line.GetV());
            }
            
        }
        if (obj.GetComponent<AttachForComponentClass>())
        {
            ComponentClass comp = obj.transform.parent.GetComponent<ComponentClass>();
            component = comp;
            if (isParallel)
            {

            }
            else
            {
                SetV(V + comp.GetV());
                SetR(R + comp.GetR());
            }
            
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
        if (obj.GetComponent<AttachForComponentClass>())
        {
            component = null;
        }
    }
    public override void SetV(float value)
    {
        V = value;
        pair.V = value;
        
    }
    public override void SetI(float value)
    {
        I = value;
        pair.I = value;

    }
    public override void SetR(float value)
    {
        R = value;
        pair.R = value;

    }
    public override void Receive()
    {
        

    }
    public override void Give()
    {
        
    }
}
