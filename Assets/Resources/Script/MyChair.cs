using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyChair : MonoBehaviour
{
    [SerializeField]
    public Material chairMaterial;

    // Variables
    float s = 0.4f;
    float s2 = 0.4f;
    float s3 = 0.2f;
    float s4 = 0.4f;
    float jarakKaki = 1.5f;
    float kakiHeight = 1.5f;
    float tebalAlas = 0.2f;
    float lebarAlas = 0.2f;
    float sandaranHeight = 2.0f;
    float lebarSandaran = 1.0f;
    float turunanSandaran = 0.1f;
    float tinggiArm = 0.3f;
    float masukanArm = 0.1f;
    float tebalArm = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        // Declaring and initializing values for our mesh
        Mesh mesh = new Mesh();
        var vertices = new Vector3[96];

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
        vertices[16] = new Vector3(0, 0, jarakKaki);
        vertices[17] = new Vector3(0, 0, s + jarakKaki);
        vertices[18] = new Vector3(s, 0, jarakKaki);
        vertices[19] = new Vector3(s, 0, s + jarakKaki);
        vertices[20] = new Vector3(0, kakiHeight, jarakKaki);
        vertices[21] = new Vector3(0, kakiHeight, s + jarakKaki);
        vertices[22] = new Vector3(s, kakiHeight, jarakKaki);
        vertices[23] = new Vector3(s, kakiHeight, s + jarakKaki);
        vertices[24] = new Vector3(jarakKaki, 0, jarakKaki);
        vertices[25] = new Vector3(jarakKaki, 0, s + jarakKaki);
        vertices[26] = new Vector3(s + jarakKaki, 0, jarakKaki);
        vertices[27] = new Vector3(s + jarakKaki, 0, s + jarakKaki);
        vertices[28] = new Vector3(jarakKaki, kakiHeight, jarakKaki);
        vertices[29] = new Vector3(jarakKaki, kakiHeight, s + jarakKaki);
        vertices[30] = new Vector3(s + jarakKaki, kakiHeight, jarakKaki);
        vertices[31] = new Vector3(s + jarakKaki, kakiHeight, s + jarakKaki);

        // Titik-titik Alas Kursi
        vertices[32] = new Vector3(0 - lebarAlas, kakiHeight, 0 - lebarAlas);
        vertices[33] = new Vector3(s + lebarAlas + jarakKaki, kakiHeight, 0 - lebarAlas);
        vertices[34] = new Vector3(0 - lebarAlas, kakiHeight, s + jarakKaki + lebarAlas);
        vertices[35] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight, s + jarakKaki + lebarAlas);
        vertices[36] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[37] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[38] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas);
        vertices[39] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas);

        // Titik-titik Penyangga Sandaran Kursi
        vertices[40] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[41] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, s2 - lebarAlas);
        vertices[42] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[43] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas, s2 - lebarAlas);
        vertices[44] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas + sandaranHeight, 0 - lebarAlas);
        vertices[45] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas + sandaranHeight, s2 - lebarAlas);
        vertices[46] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + sandaranHeight, 0 - lebarAlas);
        vertices[47] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + sandaranHeight, s2 - lebarAlas);
        vertices[48] = new Vector3(s - s2 + jarakKaki + lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[49] = new Vector3(s - s2 + jarakKaki + lebarAlas, kakiHeight + tebalAlas, s2 - lebarAlas);
        vertices[50] = new Vector3(s  + jarakKaki + lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[51] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, s2 - lebarAlas);
        vertices[52] = new Vector3(s - s2 + jarakKaki + lebarAlas, kakiHeight + tebalAlas + sandaranHeight, 0 - lebarAlas);
        vertices[53] = new Vector3(s - s2 + jarakKaki + lebarAlas, kakiHeight + tebalAlas + sandaranHeight, s2 - lebarAlas);
        vertices[54] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + sandaranHeight, 0 - lebarAlas);
        vertices[55] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + sandaranHeight, s2 - lebarAlas);

        // Titik-titik untuk sandaran kursi
        vertices[56] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas - turunanSandaran + sandaranHeight, 0 - lebarAlas);
        vertices[57] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas - turunanSandaran + sandaranHeight, s2 - lebarAlas);
        vertices[58] = new Vector3(s + jarakKaki - s2 + lebarAlas, kakiHeight + tebalAlas - turunanSandaran + sandaranHeight, 0 - lebarAlas);
        vertices[59] = new Vector3(s + jarakKaki - s2 + lebarAlas, kakiHeight + tebalAlas - turunanSandaran + sandaranHeight, s2 - lebarAlas);
        vertices[60] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas - lebarSandaran - turunanSandaran + sandaranHeight, 0 - lebarAlas);
        vertices[61] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas - lebarSandaran - turunanSandaran + sandaranHeight, s2 - lebarAlas);
        vertices[62] = new Vector3(s + jarakKaki - s2 + lebarAlas, kakiHeight + tebalAlas - lebarSandaran - turunanSandaran + sandaranHeight, 0 - lebarAlas);
        vertices[63] = new Vector3(s + jarakKaki - s2 + lebarAlas, kakiHeight + tebalAlas - lebarSandaran - turunanSandaran + sandaranHeight, s2 - lebarAlas);

        // Titik-titik untuk armrest
        vertices[64] = new Vector3(0 - lebarAlas + masukanArm, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm);
        vertices[65] = new Vector3(0 - lebarAlas + masukanArm + s3, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm);
        vertices[66] = new Vector3(0 - lebarAlas + masukanArm, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[67] = new Vector3(0 - lebarAlas + masukanArm + s3, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[68] = new Vector3(0 - lebarAlas + masukanArm, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm);
        vertices[69] = new Vector3(0 - lebarAlas + masukanArm + s3, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm);
        vertices[70] = new Vector3(0 - lebarAlas + masukanArm, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[71] = new Vector3(0 - lebarAlas + masukanArm + s3, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[72] = new Vector3(s + jarakKaki + lebarAlas - masukanArm, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm);
        vertices[73] = new Vector3(s + jarakKaki + lebarAlas - masukanArm - s3, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm);
        vertices[74] = new Vector3(s + jarakKaki + lebarAlas - masukanArm, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[75] = new Vector3(s + jarakKaki + lebarAlas - masukanArm - s3, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[76] = new Vector3(s + jarakKaki + lebarAlas - masukanArm, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm);
        vertices[77] = new Vector3(s + jarakKaki + lebarAlas - masukanArm - s3, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm);
        vertices[78] = new Vector3(s + jarakKaki + lebarAlas - masukanArm, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[79] = new Vector3(s + jarakKaki + lebarAlas - masukanArm - s3, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[80] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + tinggiArm, s2 - lebarAlas);
        vertices[81] = new Vector3(s2 - lebarAlas - s4, kakiHeight + tebalAlas + tinggiArm, s2 - lebarAlas);
        vertices[82] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s2 - lebarAlas);
        vertices[83] = new Vector3(s2 - lebarAlas - s4, kakiHeight + tebalAlas + tinggiArm + tebalArm, s2 - lebarAlas);
        vertices[84] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + tinggiArm, s2 + lebarAlas + jarakKaki);
        vertices[85] = new Vector3(s2 - lebarAlas - s4, kakiHeight + tebalAlas + tinggiArm, s2 + lebarAlas + jarakKaki);
        vertices[86] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s2 + lebarAlas + jarakKaki);
        vertices[87] = new Vector3(s2 - lebarAlas - s4, kakiHeight + tebalAlas + tinggiArm + tebalArm, s2 + lebarAlas + jarakKaki);
        vertices[88] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + tinggiArm, s - lebarAlas);
        vertices[89] = new Vector3(s + jarakKaki - s4 + lebarAlas, kakiHeight + tebalAlas + tinggiArm, s - lebarAlas);
        vertices[90] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s - lebarAlas);
        vertices[91] = new Vector3(s + jarakKaki - s4 + lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s - lebarAlas);
        vertices[92] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas);
        vertices[93] = new Vector3(s + jarakKaki - s4 + lebarAlas, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas);
        vertices[94] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s + jarakKaki + lebarAlas);
        vertices[95] = new Vector3(s + jarakKaki - s4 + lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s + jarakKaki + lebarAlas);

        

        mesh.vertices = vertices;

        var colors = new Color32[vertices.Length];
        
        // Warna kaki kursi: 
        colors[0] = new Color32(128, 0, 0, 255);
        colors[1] = new Color32(128, 0, 0, 255);
        colors[2] = new Color32(128, 0, 0, 255);
        colors[3] = new Color32(128, 0, 0, 255);
        colors[4] = new Color32(128, 0, 0, 255);
        colors[5] = new Color32(128, 0, 0, 255);
        colors[6] = new Color32(128, 0, 0, 255);
        colors[7] = new Color32(128, 0, 0, 255);
        colors[8] = new Color32(128, 0, 0, 255);
        colors[9] = new Color32(128, 0, 0, 255);
        colors[10] = new Color32(128, 0, 0, 255);
        colors[11] = new Color32(128, 0, 0, 255);
        colors[12] = new Color32(128, 0, 0, 255);
        colors[13] = new Color32(128, 0, 0, 255);
        colors[14] = new Color32(128, 0, 0, 255);
        colors[15] = new Color32(128, 0, 0, 255);
        colors[16] = new Color32(128, 0, 0, 255);
        colors[17] = new Color32(128, 0, 0, 255);
        colors[18] = new Color32(128, 0, 0, 255);
        colors[19] = new Color32(128, 0, 0, 255);
        colors[20] = new Color32(128, 0, 0, 255);
        colors[21] = new Color32(128, 0, 0, 255);
        colors[22] = new Color32(128, 0, 0, 255);
        colors[23] = new Color32(128, 0, 0, 255);
        colors[24] = new Color32(128, 0, 0, 255);
        colors[25] = new Color32(128, 0, 0, 255);
        colors[26] = new Color32(128, 0, 0, 255);
        colors[27] = new Color32(128, 0, 0, 255);
        colors[28] = new Color32(128, 0, 0, 255);
        colors[29] = new Color32(128, 0, 0, 255);
        colors[30] = new Color32(128, 0, 0, 255);
        colors[31] = new Color32(128, 0, 0, 255);

        // Warna alas kursi: 
        colors[32] = new Color32(230, 0, 0, 255);
        colors[33] = new Color32(230, 0, 0, 255);
        colors[34] = new Color32(230, 0, 0, 255);
        colors[35] = new Color32(230, 0, 0, 255);
        colors[36] = new Color32(230, 0, 0, 255);
        colors[37] = new Color32(230, 0, 0, 255);
        colors[38] = new Color32(230, 0, 0, 255);
        colors[39] = new Color32(230, 0, 0, 255);

        // Warna penyangga sandaran kursi: 
        colors[40] = new Color32(179, 89, 0, 255);
        colors[41] = new Color32(179, 89, 0, 255);
        colors[42] = new Color32(179, 89, 0, 255);
        colors[43] = new Color32(179, 89, 0, 255);
        colors[44] = new Color32(179, 89, 0, 255);
        colors[45] = new Color32(179, 89, 0, 255);
        colors[46] = new Color32(179, 89, 0, 255);
        colors[47] = new Color32(179, 89, 0, 255);
        colors[48] = new Color32(179, 89, 0, 255);
        colors[49] = new Color32(179, 89, 0, 255);
        colors[50] = new Color32(179, 89, 0, 255);
        colors[51] = new Color32(179, 89, 0, 255);
        colors[52] = new Color32(179, 89, 0, 255);
        colors[53] = new Color32(179, 89, 0, 255);
        colors[54] = new Color32(179, 89, 0, 255);
        colors[55] = new Color32(179, 89, 0, 255);

        // Warna sandaran kursi: 
        colors[56] = new Color32(255, 195, 77, 255);
        colors[57] = new Color32(255, 195, 77, 255);
        colors[58] = new Color32(255, 195, 77, 255);
        colors[59] = new Color32(255, 195, 77, 255);
        colors[60] = new Color32(255, 195, 77, 255);
        colors[61] = new Color32(255, 195, 77, 255);
        colors[62] = new Color32(255, 195, 77, 255);
        colors[63] = new Color32(255, 195, 77, 255);

        // Warna armrest:
        colors[64] = new Color32(255, 195, 77, 255);
        colors[65] = new Color32(255, 195, 77, 255);
        colors[66] = new Color32(255, 195, 77, 255);
        colors[67] = new Color32(255, 195, 77, 255);
        colors[68] = new Color32(255, 195, 77, 255);
        colors[69] = new Color32(255, 195, 77, 255);
        colors[70] = new Color32(255, 195, 77, 255);
        colors[71] = new Color32(255, 195, 77, 255);
        colors[72] = new Color32(255, 195, 77, 255);
        colors[73] = new Color32(255, 195, 77, 255);
        colors[74] = new Color32(255, 195, 77, 255);
        colors[75] = new Color32(255, 195, 77, 255);
        colors[76] = new Color32(255, 195, 77, 255);
        colors[77] = new Color32(255, 195, 77, 255);
        colors[78] = new Color32(255, 195, 77, 255);
        colors[79] = new Color32(255, 195, 77, 255);
        colors[80] = new Color32(102, 0, 0, 255);
        colors[81] = new Color32(102, 0, 0, 255);
        colors[82] = new Color32(102, 0, 0, 255);
        colors[83] = new Color32(102, 0, 0, 255);
        colors[84] = new Color32(102, 0, 0, 255);
        colors[85] = new Color32(102, 0, 0, 255);
        colors[86] = new Color32(102, 0, 0, 255);
        colors[87] = new Color32(102, 0, 0, 255);
        colors[88] = new Color32(102, 0, 0, 255);
        colors[89] = new Color32(102, 0, 0, 255);
        colors[90] = new Color32(102, 0, 0, 255);
        colors[91] = new Color32(102, 0, 0, 255);
        colors[92] = new Color32(102, 0, 0, 255);
        colors[93] = new Color32(102, 0, 0, 255);
        colors[94] = new Color32(102, 0, 0, 255);
        colors[95] = new Color32(102, 0, 0, 255);

        mesh.colors32 = colors;

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

            // Segitiga untuk Penyangga Sandaran Kursi
            40, 41, 42,
            43, 42, 41,
            44, 45, 46,
            47, 46, 45,
            46, 42, 40,
            40, 44, 46,
            47, 43, 42,
            42, 46, 47,
            45, 41, 43,
            47, 45, 43,
            40, 41, 44,
            41, 45, 44,
            48, 49, 50,
            51, 50, 49,
            52, 53, 54,
            55, 54, 53,
            54, 50, 48,
            48, 52, 54,
            55, 51, 50,
            50, 54, 55,
            53, 49, 51,
            55, 53, 51,
            48, 49, 52,
            49, 53, 52,

            // Segitiga untuk sandaran kursi
            56, 57, 58,
            59, 58, 57,
            62, 61, 60,
            61, 62, 63,
            56, 58, 60,
            62, 60, 58,
            59, 61, 63,
            61, 59, 57,
            
            // Segitiga untuk armrest
            64, 65, 66,     
            67, 66, 65,
            71, 70, 69,
            68, 69, 70,
            70, 66, 64,
            64, 68, 70,
            71, 67, 66,
            66, 70, 71,
            69, 65, 67,
            71, 69, 67,
            64, 65, 68,
            65, 69, 68,
            72, 73, 74,     
            75, 74, 74,
            79, 78, 77,
            76, 77, 78,
            78, 74, 72,
            72, 76, 78,
            79, 75, 74,
            74, 78, 79,
            77, 73, 75,
            79, 77, 75,
            72, 73, 76,
            73, 77, 76,
            82, 81, 80,
            81, 82, 83,
            86, 85, 84,
            85, 86, 87,
            80, 82, 86,
            86, 84, 80,
            82, 83, 87,
            87, 86, 82,
            83, 81, 85,
            83, 85, 87,
            84, 81, 80,
            84, 85, 81,
            90, 89, 88,
            89, 90, 91,
            94, 93, 92,
            93, 94, 95,
            88, 90, 94,
            94, 92, 88,
            90, 91, 95,
            95, 94, 90,
            91, 89, 93,
            91, 93, 95,
            92, 89, 88,
            92, 93, 89,
        };
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = chairMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
