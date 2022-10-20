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
        var vertices = new Vector3[84];
        var uvs = new Vector2[vertices.Length];

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
        vertices[32] = new Vector3(0, 0, 0);
        vertices[33] = new Vector3(0, 0, s);
        vertices[34] = new Vector3(s, 0, 0);
        vertices[35] = new Vector3(s, 0, s);
        vertices[36] = new Vector3(0, kakiHeight, 0);
        vertices[37] = new Vector3(0, kakiHeight, s);
        vertices[38] = new Vector3(s, kakiHeight, 0);
        vertices[39] = new Vector3(s, kakiHeight, s);
        vertices[40] = new Vector3(jarakKaki, 0, 0);
        vertices[41] = new Vector3(jarakKaki, 0, s);
        vertices[42] = new Vector3(s + jarakKaki, 0, 0);
        vertices[43] = new Vector3(s + jarakKaki, 0, s);
        vertices[44] = new Vector3(jarakKaki, kakiHeight, 0);
        vertices[45] = new Vector3(jarakKaki, kakiHeight, s);
        vertices[46] = new Vector3(s + jarakKaki, kakiHeight, 0);
        vertices[47] = new Vector3(s + jarakKaki, kakiHeight, s);
        vertices[48] = new Vector3(0, 0, jarakKaki/2);
        vertices[49] = new Vector3(0, 0, s + jarakKaki/2);
        vertices[50] = new Vector3(s, 0, jarakKaki/2);
        vertices[51] = new Vector3(s, 0, s + jarakKaki/2);
        vertices[52] = new Vector3(0, kakiHeight, jarakKaki/2);
        vertices[53] = new Vector3(0, kakiHeight, s + jarakKaki/2);
        vertices[54] = new Vector3(s, kakiHeight, jarakKaki/2);
        vertices[55] = new Vector3(s, kakiHeight, s + jarakKaki/2);
        vertices[56] = new Vector3(jarakKaki, 0, jarakKaki/2);
        vertices[57] = new Vector3(jarakKaki, 0, s + jarakKaki/2);
        vertices[58] = new Vector3(s + jarakKaki, 0, jarakKaki/2);
        vertices[59] = new Vector3(s + jarakKaki, 0, s + jarakKaki/2);
        vertices[60] = new Vector3(jarakKaki, kakiHeight, jarakKaki/2);
        vertices[61] = new Vector3(jarakKaki, kakiHeight, s + jarakKaki/2);
        vertices[62] = new Vector3(s + jarakKaki, kakiHeight, jarakKaki/2);
        vertices[63] = new Vector3(s + jarakKaki, kakiHeight, s + jarakKaki/2);

        // sisi bawah papan meja
        vertices[64] = new Vector3(0 - lebarAlas, kakiHeight, 0 - lebarAlas);
        vertices[65] = new Vector3(s + lebarAlas + jarakKaki, kakiHeight, 0 - lebarAlas);
        vertices[66] = new Vector3(0 - lebarAlas, kakiHeight, s + jarakKaki/2 + lebarAlas);
        vertices[67] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight, s + jarakKaki/2 + lebarAlas);
        // sisi atas papan meja
        vertices[68] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[69] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[70] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, s + jarakKaki/2 + lebarAlas);
        vertices[71] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, s + jarakKaki/2 + lebarAlas);

        vertices[72] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[73] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[74] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, s + jarakKaki/2 + lebarAlas);
        vertices[75] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, s + jarakKaki/2 + lebarAlas);

        // sisi bawah papan meja
        vertices[76] = new Vector3(0 - lebarAlas, kakiHeight, 0 - lebarAlas);
        vertices[77] = new Vector3(s + lebarAlas + jarakKaki, kakiHeight, 0 - lebarAlas);
        vertices[78] = new Vector3(0 - lebarAlas, kakiHeight, s + jarakKaki/2 + lebarAlas);
        vertices[79] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight, s + jarakKaki/2 + lebarAlas);
        // sisi atas papan meja
        vertices[80] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[81] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[82] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, s + jarakKaki/2 + lebarAlas);
        vertices[83] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, s + jarakKaki/2 + lebarAlas);

        for(int i=0; i<32; i += 8){
            uvs[i] = new Vector2(0.0f, 0.0f);
            uvs[i+1] = new Vector2(0.0f, 1.0f);
            uvs[i+2] = new Vector2(0.5f, 0.0f);
            uvs[i+3] = new Vector2(0.5f, 1.0f);
            uvs[i+4] = new Vector2(0.5f, 0.0f);
            uvs[i+5] = new Vector2(0.5f, 1.0f);
            uvs[i+6] = new Vector2(0.0f, 0.0f);
            uvs[i+7] = new Vector2(0.0f, 1.0f);   
        }
        for(int i=32; i<64; i += 8){
            uvs[i] = new Vector2(0.0f, 1.0f); 
            uvs[i+1] = new Vector2(0.0f, 1.0f); 
            uvs[i+2] = new Vector2(0.0f, 0.0f);
            uvs[i+3] = new Vector2(0.0f, 0.0f);
            uvs[i+4] = new Vector2(0.5f, 1.0f);
            uvs[i+5] = new Vector2(0.5f, 1.0f);
            uvs[i+6] = new Vector2(0.5f, 0.0f);
            uvs[i+7] = new Vector2(0.5f, 0.0f);
        }
        for(int i=64; i<71; i += 8){
            uvs[i] = new Vector2(0.0f, 0.0f);
            uvs[i+1] = new Vector2(0.0f, 1.0f);
            uvs[i+2] = new Vector2(0.5f, 0.0f);
            uvs[i+3] = new Vector2(0.5f, 1.0f);
            uvs[i+4] = new Vector2(0.5f, 0.0f);
            uvs[i+5] = new Vector2(0.5f, 1.0f);
            uvs[i+6] = new Vector2(0.0f, 0.0f);
            uvs[i+7] = new Vector2(0.0f, 1.0f);   
        }
        
        uvs[72] = new Vector2(1.0f, 1.0f);
        uvs[73] = new Vector2(0.5f, 1.0f);
        uvs[74] = new Vector2(1.0f, 0.0f);
        uvs[75] = new Vector2(0.5f, 0.0f);

        for(int i=76; i<84; i += 8){
            uvs[i] = new Vector2(0.0f, 1.0f); 
            uvs[i+1] = new Vector2(0.0f, 1.0f); 
            uvs[i+2] = new Vector2(0.0f, 0.0f);
            uvs[i+3] = new Vector2(0.0f, 0.0f);
            uvs[i+4] = new Vector2(0.5f, 1.0f);
            uvs[i+5] = new Vector2(0.5f, 1.0f);
            uvs[i+6] = new Vector2(0.5f, 0.0f);
            uvs[i+7] = new Vector2(0.5f, 0.0f);
        }
        
        

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            // Segitiga untuk kaki kursi
            2, 1, 0,
            1, 2, 3,
            4, 5, 6,
            7, 6, 5,
            32+6, 32+2, 32+0,
            32+0, 32+4, 32+6,
            7, 3, 2,
            2, 6, 7,
            32+5, 32+1, 32+3,
            32+7, 32+5, 32+3,
            0, 1, 4,
            1, 5, 4,
            10, 9, 8,
            9, 10, 11,
            12, 13, 14,
            15, 14, 13,
            32+14, 32+10, 32+8,
            32+8, 32+12, 32+14,
            15, 11, 10,
            10, 14, 15,
            32+13, 32+9,  32+11,
            32+15, 32+13, 32+11,
            8, 9, 12,
            9, 13, 12,
            18, 17, 16,
            17, 18, 19,
            20, 21, 22,
            23, 22, 21,
            32+22, 32+18, 32+16,
            32+16, 32+20, 32+22,
            23, 19, 18,
            18, 22, 23,
            32+21, 32+17, 32+19,
            32+23, 32+21, 32+19,
            16, 17, 20,
            17, 21, 20,
            26, 25, 24,
            25, 26, 27,
            28, 29, 30,
            31, 30, 29,
            32+30, 32+26, 32+24,
            32+24, 32+28, 32+30,
            31, 27, 26,
            26, 30, 31,
            32+29, 32+25, 32+27,
            32+31, 32+29, 32+27,
            24, 25, 28,
            25, 29, 28,
            
            // Segitiga untuk alas kursi
            32+32, 32+33, 32+34,
            32+35, 32+34, 32+33,
            32+36, 32+33, 32+32,
            32+33, 32+36, 32+37,
            12+32+39, 12+32+35, 12+32+33,
            12+32+33, 12+32+37, 12+32+39,
            32+38, 32+34, 32+35,
            32+35, 32+39, 32+38,
            12+32+32, 12+32+34, 12+32+38,
            12+32+38, 12+32+36, 12+32+32,

            32+42, 32+41, 32+40,
            32+41, 32+42, 32+43,
        };

        mesh.uv = uvs;

        GetComponent<MeshFilter>().mesh = mesh;

        mesh.RecalculateNormals();

        GetComponent<MeshRenderer>().material = chairMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
