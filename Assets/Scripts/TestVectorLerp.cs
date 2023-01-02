using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class TestVectorLerp : MonoBehaviour
{
    //public Transform objetA, objetB, objetC;
    public List<Transform> transforms;
    

    private void Start()
    {
        var bound = new Bounds(transforms[0].position, Vector3.zero);
        for(int i = 1; i < transforms.Count; i++)
        {
            bound.Encapsulate(transforms[i].position);
        }
        
    }

    /*public Vector3 FindCenterOfTransforms(List<Transform> transforms)
    {
        var bound = new Bounds(transforms[0].position, Vector3.zero);
        for (int i = 1; i < transforms.Count; i++)
        {
            bound.Encapsulate(transforms[i].position);
        }
        return bound.center;
    }*/

    private void OnDrawGizmos()
    {
        var bound = new Bounds(transforms[0].position, Vector3.zero);
        for (int i = 1; i < transforms.Count; i++)
        {
            bound.Encapsulate(transforms[i].position);
        }
        Gizmos.DrawSphere(bound.center, 20);
    }

}
