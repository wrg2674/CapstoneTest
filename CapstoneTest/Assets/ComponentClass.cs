using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ComponentClass : MonoBehaviour
{
    [SerializeField]protected float V; // ����
    [SerializeField]protected float I; // ����
    [SerializeField]protected float R; // ����

    public Transform[] pos = new Transform[2]; // Inspector â���� �� ������Ʈ�� ��ġ�� �����������
    public AttachForComponentClass[] attach = new AttachForComponentClass[2]; // Inspector â���� �����������
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
