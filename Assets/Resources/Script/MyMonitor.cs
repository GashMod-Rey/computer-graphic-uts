using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMonitor : MonoBehaviour
{
    [SerializeField]
    public Material chairMaterial;

    // Variables
    float s = 0.5f;
    float tebal = 0.2f;
    float naik = 0.5f;
    float t = 4.0f;
    float det = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        // Declaring and initializing values for our mesh
        Mesh mesh = new Mesh();
        var vertices = new Vector3[25];

        // Titik-titik tangkai monitor
        vertices[0] = new Vector3(-s, naik, -s);
        vertices[1] = new Vector3(s, naik, -s);
        vertices[2] = new Vector3(-s + det, t + naik, -s + det);
        vertices[3] = new Vector3(s-det, t + naik, -s + det);
        vertices[4] = new Vector3(-s, naik, -s + tebal);
        vertices[5] = new Vector3(s, naik, -s + tebal);
        vertices[6] = new Vector3(-s + det, t + naik, -s + tebal + det);
        vertices[7] = new Vector3(s-det, t + naik, -s + tebal + det);
        vertices[8] = new Vector3(-s, naik, s);
        vertices[9] = new Vector3(-s + det, t + naik, s-det);
        vertices[10] = new Vector3(-s + tebal, naik, s);
        vertices[11] = new Vector3(-s + tebal + det, t + naik, s-det);
        vertices[12] = new Vector3(-s + tebal, naik, -s + tebal);
        vertices[13] = new Vector3(-s + tebal + det, t + naik, -s + tebal + det);

        // Titik-titik kaki monitor
        vertices[14] = new Vector3(-s + t, naik, -s);
        vertices[15] = new Vector3(-s + t, naik, s);
        vertices[16] = new Vector3(-s + t + det, 0, -s - 0.2f);
        vertices[17] = new Vector3(-s + t + det, 0, s + 0.2f);
        vertices[18] = new Vector3(-s, 0, -s);
        vertices[19] = new Vector3(-s, 0, s);
        vertices[20] = new Vector3(-s, naik, -s + t);
        vertices[21] = new Vector3(s, naik, -s + t);
        vertices[22] = new Vector3(-s - 0.2f, 0, -s + t + det);
        vertices[23] = new Vector3(s + 0.2f, 0, -s + t + det);
        vertices[24] = new Vector3(s, 0, -s);

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            // Segitiga untuk tangkai monitor
            0, 2, 1,
            2, 3, 1,
            0, 4, 6,
            0, 6, 2,
            5, 6, 4,
            5, 7, 6,
            1, 5, 4,
            1, 4, 0,
            6, 7, 3,
            2, 6, 3,
            3, 7, 5,
            3, 5, 1,

            0, 8, 9,
            2, 0, 9,
            10, 9, 8,
            11, 9, 10,
            13, 11, 10,
            10, 12, 13,
            12, 10, 8,
            4, 12, 8,
            9, 11, 13,
            9, 13, 6,

            // Segitiga kaki monitor
            0, 8, 14,
            15, 14, 8,
            16, 17, 18,
            18, 17, 19,
            14, 15, 16,
            17, 16, 15,
            18, 8, 0,
            8, 18, 19,
            18, 0, 14,
            14, 16, 18,
            15, 19, 17,
            19, 15, 8,

            20, 1, 0,
            1, 20, 21,
            23, 22, 18,
            24, 23, 18,
            22, 21, 20,
            21, 22, 23,
            18, 22, 20,
            20, 0, 18,
            21, 24, 1,
            23, 24, 21,
        };
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = chairMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }  
}
