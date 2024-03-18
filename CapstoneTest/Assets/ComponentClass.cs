using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ComponentClass : MonoBehaviour
{
    [SerializeField]protected float V; // 전압
    [SerializeField]protected float I; // 전류
    [SerializeField]protected float R; // 저항

    public Transform[] pos = new Transform[2]; // Inspector 창에서 빈 오브젝트로 위치를 지정해줘야함
    public AttachForComponentClass[] attach = new AttachForComponentClass[2]; // Inspector 창에서 지정해줘야함
    public enum Direction { ENTER, EXIT};
    public abstract void Do();
    public float GetV()
    {
        return V;
    }
    public float GetI()
    {
        return I;
    }
    public float GetR()
    {
        return R;
    }
    public virtual void Receive()
    {
        int size = attach[(int)(Direction.ENTER)].link.Count;
        for(int i=0; i < size; i++)
        {
            I += attach[(int)(Direction.ENTER)].link[i].GetComponent<LineClass>().GetI();
        }
        V = I * R;
    }
}
