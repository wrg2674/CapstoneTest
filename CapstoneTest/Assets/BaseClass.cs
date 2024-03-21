using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseClass : MonoBehaviour
{
    [SerializeField] protected float V; // ����
    [SerializeField] protected float I; // ����
    [SerializeField] protected float R; // ����
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
    public abstract void Receive();
    public abstract void Give();
}
