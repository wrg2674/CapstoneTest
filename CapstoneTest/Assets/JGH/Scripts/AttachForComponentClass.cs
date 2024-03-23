using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 전기회로도에 있는 부품들은 전선하고만 연결이 가능해야함 -> 부품들끼리는 연결되면 안됨
public class AttachForComponentClass : MonoBehaviour
{
    public List<LineClass> link = new List<LineClass>();
    public void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.GetComponent<LineClass>())
        {
            link.Add(obj.GetComponent<LineClass>());
        }
        
    }
    public void OnTriggerExit(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.GetComponent<LineClass>())
        {
            link.Remove(obj.GetComponent<LineClass>());
        }
        
    }
}
