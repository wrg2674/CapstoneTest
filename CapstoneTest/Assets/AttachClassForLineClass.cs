using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ������ ����ȸ�ε��� �ִ� ��ǰ��� �ٸ� �����ϰ� ������ ������
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
