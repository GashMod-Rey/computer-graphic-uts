using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMonitorLCD : MonoBehaviour
{
    [SerializeField]
    public Material chairMaterial;
    Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        // Declaring and initializing values for our mesh
        Mesh mesh = new Mesh();
        var vertices = new Vector3[8];
        var uvs = new Vector2[vertices.Length];
        myTexture = Resources.Load<Texture>("Textures/carbon");

        // Titik-titik tangkai monitor
        vertices[0] = new Vector3(0, 2.25f, 0);
        vertices[1] = new Vector3(0, 2.25f, 0.75f);
        vertices[2] = new Vector3(9, 2.25f, 0);
        vertices[3] = new Vector3(9, 2.25f, 0.75f);
        vertices[4] = new Vector3(0, 6.25f, 0);
        vertices[5] = new Vector3(0, 6.25f, 0.75f);
        vertices[6] = new Vector3(9, 6.25f, 0);
        vertices[7] = new Vector3(9, 6.25f, 0.75f);

        // uvs[0] = new Vector2(0.0f, 0.5f);
        // uvs[1] = new Vector2(0.25f, 0.5f);
        // uvs[2] = new Vector2(0.0f, 0.0f);
        // uvs[3] = new Vector2(0.25f, 0.0f);
        // uvs[4] = new Vector2(0.25f, 0.5f);
        // uvs[5] = new Vector2(0.5f, 0.5f);
        // uvs[6] = new Vector2(0.25f, 0.0f);
        // uvs[7] = new Vector2(0.5f, 0.0f);

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            2, 1, 0,
            1, 2, 3,
            4, 5, 6,
            7, 6, 5,
            6, 2, 0,
            0, 4, 6,
            7, 3, 2,
            2, 6, 7,
            5, 1, 3,
            7, 5, 3,
            0, 1, 4,
            1, 5, 4,
        };
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = chairMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }  
}
