using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTable : MonoBehaviour
{
    [SerializeField]
    public Material chairMaterial;

    // Variables
    float s = 0.7f;
    float jarakKaki = 7.0f;
    float kakiHeight = 4.0f;
    float tebalAlas = 0.8f;
    float lebarAlas = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Declaring and initializing values for our mesh
        Mesh mesh = new Mesh();
        var vertices = new Vector3[40];

        // Titik-titik Kaki Kursi
        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 0, s);
        vertices[2] = new Vector3(s, 0, 0);
        vertices[3] = new Vector3(s, 0, s);
        vertices[4] = new Vector3(0, kakiHeight, 0);
        vertices[5] = new Vector3(0, kakiHeight, s);
        vertices[6] = new Vector3(s, kakiHeight, 0);
        vertices[7] = new Vector3(s, kakiHeight, s);
        vertices[8] = new Vector3(jarakKaki, 0, 0);
        vertices[9] = new Vector3(jarakKaki, 0, s);
        vertices[10] = new Vector3(s + jarakKaki, 0, 0);
        vertices[11] = new Vector3(s + jarakKaki, 0, s);
        vertices[12] = new Vector3(jarakKaki, kakiHeight, 0);
        vertices[13] = new Vector3(jarakKaki, kakiHeight, s);
        vertices[14] = new Vector3(s + jarakKaki, kakiHeight, 0);
        vertices[15] = new Vector3(s + jarakKaki, kakiHeight, s);
        vertices[16] = new Vector3(0, 0, jarakKaki/2);
        vertices[17] = new Vector3(0, 0, s + jarakKaki/2);
        vertices[18] = new Vector3(s, 0, jarakKaki/2);
        vertices[19] = new Vector3(s, 0, s + jarakKaki/2);
        vertices[20] = new Vector3(0, kakiHeight, jarakKaki/2);
        vertices[21] = new Vector3(0, kakiHeight, s + jarakKaki/2);
        vertices[22] = new Vector3(s, kakiHeight, jarakKaki/2);
        vertices[23] = new Vector3(s, kakiHeight, s + jarakKaki/2);
        vertices[24] = new Vector3(jarakKaki, 0, jarakKaki/2);
        vertices[25] = new Vector3(jarakKaki, 0, s + jarakKaki/2);
        vertices[26] = new Vector3(s + jarakKaki, 0, jarakKaki/2);
        vertices[27] = new Vector3(s + jarakKaki, 0, s + jarakKaki/2);
        vertices[28] = new Vector3(jarakKaki, kakiHeight, jarakKaki/2);
        vertices[29] = new Vector3(jarakKaki, kakiHeight, s + jarakKaki/2);
        vertices[30] = new Vector3(s + jarakKaki, kakiHeight, jarakKaki/2);
        vertices[31] = new Vector3(s + jarakKaki, kakiHeight, s + jarakKaki/2);

        // Titik-titik Alas Kursi
        vertices[32] = new Vector3(0 - lebarAlas, kakiHeight, 0 - lebarAlas);
        vertices[33] = new Vector3(s + lebarAlas + jarakKaki, kakiHeight, 0 - lebarAlas);
        vertices[34] = new Vector3(0 - lebarAlas, kakiHeight, s + jarakKaki/2 + lebarAlas);
        vertices[35] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight, s + jarakKaki/2 + lebarAlas);
        vertices[36] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[37] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[38] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, s + jarakKaki/2 + lebarAlas);
        vertices[39] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, s + jarakKaki/2 + lebarAlas);     

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            // Segitiga untuk kaki kursi
            0, 1, 2,
            3, 2, 1,
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
            8, 9, 10,
            11, 10, 9,
            12, 13, 14,
            15, 14, 13,
            14, 10, 8,
            8, 12, 14,
            15, 11, 10,
            10, 14, 15,
            13, 9, 11,
            15, 13, 11,
            8, 9, 12,
            9, 13, 12,
            16, 17, 18,
            19, 18, 17,
            20, 21, 22,
            23, 22, 21,
            22, 18, 16,
            16, 20, 22,
            23, 19, 18,
            18, 22, 23,
            21, 17, 19,
            23, 21, 19,
            16, 17, 20,
            17, 21, 20,
            24, 25, 26,
            27, 26, 25,
            28, 29, 30,
            31, 30, 29,
            30, 26, 24,
            24, 28, 30,
            31, 27, 26,
            26, 30, 31,
            29, 25, 27,
            31, 29, 27,
            24, 25, 28,
            25, 29, 28,
            
            // Segitiga untuk alas kursi
            32, 33, 34,
            35, 34, 33,
            38, 37, 36,
            37, 38, 39,
            36, 33, 32,
            33, 36, 37,
            39, 35, 33,
            33, 37, 39,
            38, 34, 35,
            35, 39, 38,
            32, 34, 38,
            38, 36, 32,
        };
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = chairMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
