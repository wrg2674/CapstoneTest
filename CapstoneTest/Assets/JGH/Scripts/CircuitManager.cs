using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using MyEnum;

// ��ȸ�� DFS �ؾ���
public class CircuitManager : MonoBehaviour
{

    private List<float> R = new List<float>();
    private List<float> V = new List<float>();
    private List<float> I = new List<float>();
    
    public void calcEntireR(ComponentClass root)
    {
        if (root == null) return;
        Stack<ComponentClass> s = new Stack<ComponentClass>();

        s.Push(root);
        while(s.Count > 0)
        {
            ComponentClass cur = s.Pop();
            cur.attachment[]
            
        }

    }
}
