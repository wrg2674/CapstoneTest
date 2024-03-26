using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using MyEnum;
using static Unity.VisualScripting.Antlr3.Runtime.Tree.TreeWizard;

public static class CalcManager
{
    public delegate S bfsFunction<S>(S param);
    public static void bfs<T>(ComponentClass root)
    {
        Queue<ComponentClass> q = new Queue<ComponentClass>();
        
        q.Enqueue(root);
        while (q.Count != 0)
        {
            ComponentClass cur = q.Dequeue();
            if(cur == root && root.visit)
            {
                break;
            }
            root.visit = true;
            int size = cur.attach[(int)Direction.EXIT].link.Count;
            for(int i=0; i < size; i++)
            {
                ComponentClass tmp = cur.attach[(int)Direction.EXIT].link[i].component;
                if (tmp.visit)
                {
                    continue;
                }
                q.Enqueue(tmp);
                tmp.visit = true;
            }
        }
    }
    public static void Calculate(ComponentClass root)
    {
        float cirV = 0.0f;
        float cirR = 0.0f;
        float cirI = 0.0f;
        bool success = false;
        cirV = root.GetV();

        // BFS 시작
        Queue<ComponentClass> q = new Queue<ComponentClass>();

        q.Enqueue(root);
        while (q.Count != 0)
        {
            ComponentClass cur = q.Dequeue();
            if (cur == root && root.visit)
            {
                break;
            }
            root.visit = true;
            int size = cur.attach[(int)Direction.EXIT].link.Count;
            for (int i = 0; i < size; i++)
            {
                ComponentClass tmp = cur.attach[(int)Direction.EXIT].link[i].component;
                if (tmp.visit)
                {
                    continue;
                }
                q.Enqueue(tmp);
                tmp.visit = true;
            }
        }

        // BFS 끝

    }
    // 직렬 연결된 저항의 전체 저항을 계산하는 함수
    public static float SeriesCalcR(BaseClass value)
    {
        return value.GetR();
    }
    // 병렬 연결된 저항의 전체 저항을 계산하는 함수
    public static void ParallelCalcR(ref float R, List<BaseClass> list)
    {
        int size = list.Count;
        float tmp = 0.0f;
        for(int i=0; i < size; i++)
        {
            tmp += 1/list[i].GetR();
        }
        R += 1 / tmp;
    }
    public static void SeriesCalcV(ref float V, BaseClass value)
    {
        V += value.GetV();
    }
    public static void ParallelCalcV(ref float V, List<BaseClass> list)
    {

    }
    public static void SeriesCalcI(ref float I, BaseClass value)
    {

    }
    public static void ParallelCalcI(ref float I, List<BaseClass> list)
    {

    }
}
