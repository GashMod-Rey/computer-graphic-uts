using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTerrain : MonoBehaviour
{
    [SerializeField]
    public Material terrainMaterial;
    Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        // Declaring and initializing values for our mesh
        Mesh mesh = new Mesh();
        var vertices = new Vector3[4];
        var uvs = new Vector2[vertices.Length];

        // Titik-titik tangkai monitor
        vertices[0] = new Vector3(0, 2, 0);
        vertices[1] = new Vector3(1000, 2, 0);
        vertices[2] = new Vector3(0, 2, 1000);
        vertices[3] = new Vector3(1000, 2, 1000);

        uvs[0] = new Vector2(1.0f, 0.0f);
        uvs[1] = new Vector2(0.0f, 0.0f);
        uvs[2] = new Vector2(1.0f, 1.0f);
        uvs[3] = new Vector2(0.0f, 1.0f);

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            2, 1, 0,
            1, 2, 3,
        };
        mesh.RecalculateNormals();
        mesh.uv = uvs;
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = terrainMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }  
}
