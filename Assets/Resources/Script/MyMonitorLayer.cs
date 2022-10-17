using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMonitorLayer : MonoBehaviour
{
    [SerializeField]
    public Material chairMaterial;
    Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        // Declaring and initializing values for our mesh
        Mesh mesh = new Mesh();
        var vertices = new Vector3[4];
        var uvs = new Vector2[vertices.Length];

        // Titik-titik tangkai monitor
        vertices[0] = new Vector3(0, 2.25f, 0);
        vertices[1] = new Vector3(9, 2.25f, 0);
        vertices[2] = new Vector3(0, 6.25f, 0);
        vertices[3] = new Vector3(9, 6.25f, 0);

        uvs[0] = new Vector2(1.0f, 0.0f);
        uvs[1] = new Vector2(0.0f, 0.0f);
        uvs[2] = new Vector2(1.0f, 1.0f);
        uvs[3] = new Vector2(0.0f, 1.0f);

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            0, 1, 2,
            3, 2, 1,
        };
        mesh.RecalculateNormals();
        mesh.uv = uvs;
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = chairMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }  
}
