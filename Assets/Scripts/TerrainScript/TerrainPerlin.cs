using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainPerlin : MonoBehaviour
{
    // Start is called before the first frame update
    private int resolution = 64;
    [SerializeField]
    private Terrain ter;

    public float power = 3.0f;
    public float scale = 1.0f;
    private Vector2 startPoint = new Vector2(0f, 0f);
    [SerializeField]
    private MeshFilter filter;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        makeNoise();
    }

    void makeNoise()
    {
        print("perlin NO");
        Vector3[] vertices = filter.mesh.vertices;
        for (int i = 0; i < vertices.Length; i++)
        {
            print("perlin");
            print(vertices[i]);
            float x = startPoint.x + vertices[i].x * scale;
            float z = startPoint.y + vertices[i].z * scale;
            vertices[i].y = ((Mathf.PerlinNoise(x, z) - 0.5f) * power);
        }
        filter.mesh.vertices = vertices;
        filter.mesh.RecalculateBounds();
        filter.mesh.RecalculateNormals();
    }
}
