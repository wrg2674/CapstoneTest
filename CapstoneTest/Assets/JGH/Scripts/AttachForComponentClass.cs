using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ����ȸ�ε��� �ִ� ��ǰ���� �����ϰ� ������ �����ؾ��� -> ��ǰ�鳢���� ����Ǹ� �ȵ�
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
