using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircuitManager : MonoBehaviour
{

    private List<float> R = new List<float>();
    private List<float> V = new List<float>();
    private List<float> I = new List<float>();
    
    public void calcEntireR(ComponentClass root)
    {
        if (root == null) return;

    }
}
