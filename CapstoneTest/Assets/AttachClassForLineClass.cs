using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 전선은 전기회로도에 있는 부품들과 다른 전선하고 연결이 가능함
public class AttachClassForLineClass : MonoBehaviour
{
    private List<LineClass> link = new List<LineClass>();
    public ComponentClass component;
    [SerializeField] private AttachClassForLineClass pair; 
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
