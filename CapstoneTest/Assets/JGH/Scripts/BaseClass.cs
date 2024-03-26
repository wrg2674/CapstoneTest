using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseClass : MonoBehaviour
{
    [SerializeField] protected float V; // 전압
    [SerializeField] protected float I; // 전류
    [SerializeField] protected float R; // 저항
    public bool visit = false;
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
    public virtual void SetV(float value)
    {
        V = value;
    }
    public virtual void SetI(float value)
    {
        I = value;
    }
    public virtual void SetR(float value)
    {
        R = value;
    }
    public abstract void Receive();
    public abstract void Give();
}
