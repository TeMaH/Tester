using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class MeshGenerator : MonoBehaviour
{
    Mesh mesh;
    void Start()
    {
        mesh = new Mesh();

        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = GenerateVertices();
        mesh.triangles = GenerateTriangles();
        mesh.RecalculateNormals();
    }

    Vector3[] GenerateVertices()
    {
        return new Vector3[]
        {
            new Vector3 (0.0f, 0.0f, 0.0f),
            new Vector3 (0.0f, 0.0f, 1.0f),
            new Vector3 (1.0f, 0.0f, 0.0f),
            new Vector3 (1.0f, 0.0f, 1.0f)
        };
    }

    int[] GenerateTriangles()
    {
        return new int[] { 0, 1, 2, 1, 3, 2 };
    }
}
