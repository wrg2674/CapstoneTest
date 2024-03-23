using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public static class CalcManager
{
    public static void SeriesCalcR(ref float R, BaseClass value)
    {
        R += value.GetR();
    }
    public static void ParallelCalcR(ref float R, List<BaseClass> list)
    {
        float value = 0.0f;
        for(int i=0; i < list.Count; i++)
        {
            value += 1 / list[i].GetR();
        }
        R += 1 / value;
    }
    public static void SeriesCalcV(ref float V, BaseClass value)
    {
        V += value.GetV();
    }
    public static void ParallelCalcV(ref float V, List<BaseClass> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i].SetV(V);
        }
    }
    public static void SeriesCalcI(ref float I, BaseClass value)
    {
        value.SetI(I); 
    }
    public static void ParallelCalcI(ref float I, List<BaseClass> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            I += list[i].GetI();
        }
    }
}
