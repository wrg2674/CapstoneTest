using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 전선은 전기회로도에 있는 부품들과 다른 전선하고 연결이 가능함
public class AttachClassForLineClass : MonoBehaviour
{
    public List<ComponentClass> link = new List<ComponentClass>();
    public void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.GetComponent<ComponentClass>() == null)
        {
            return;
        }
        link.Add(obj.GetComponent<ComponentClass>());
    }
    public void OnTriggerExit(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.GetComponent<ComponentClass>() == null)
        {
            return;
        }
        link.Remove(obj.GetComponent<ComponentClass>());
    }
}
