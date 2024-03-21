using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ������ ����ȸ�ε��� �ִ� ��ǰ��� �ٸ� �����ϰ� ������ ������
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
