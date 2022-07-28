using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChageShape : MonoBehaviour
{
    [SerializeField]
    public Mesh changeShapeTo;
    private void Start()
    {
        changeShapeTo = Resources.GetBuiltinResource<Mesh>("Sphere.fbx");
    }


    private void OnCollisionEnter()
    {
        var mesh = GetComponent<MeshFilter>();
        mesh.mesh = changeShapeTo;
    }
}
