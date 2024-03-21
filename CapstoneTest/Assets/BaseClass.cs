using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseClass : MonoBehaviour
{
    [SerializeField] protected float V; // 전압
    [SerializeField] protected float I; // 전류
    [SerializeField] protected float R; // 저항
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
