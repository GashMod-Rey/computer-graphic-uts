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
        var vertices = new Vector3[192];
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

        // Duplikat-1
        vertices[96] = new Vector3(0, 0, 0);
        vertices[97] = new Vector3(0, 0, s);
        vertices[98] = new Vector3(s, 0, 0);
        vertices[99] = new Vector3(s, 0, s);
        vertices[100] = new Vector3(0, kakiHeight, 0);
        vertices[101] = new Vector3(0, kakiHeight, s);
        vertices[102] = new Vector3(s, kakiHeight, 0);
        vertices[103] = new Vector3(s, kakiHeight, s);
        vertices[104] = new Vector3(jarakKaki, 0, 0);
        vertices[105] = new Vector3(jarakKaki, 0, s);
        vertices[106] = new Vector3(s + jarakKaki, 0, 0);
        vertices[107] = new Vector3(s + jarakKaki, 0, s);
        vertices[108] = new Vector3(jarakKaki, kakiHeight, 0);
        vertices[109] = new Vector3(jarakKaki, kakiHeight, s);
        vertices[110] = new Vector3(s + jarakKaki, kakiHeight, 0);
        vertices[111] = new Vector3(s + jarakKaki, kakiHeight, s);
        vertices[112] = new Vector3(0, 0, jarakKaki);
        vertices[113] = new Vector3(0, 0, s + jarakKaki);
        vertices[114] = new Vector3(s, 0, jarakKaki);
        vertices[115] = new Vector3(s, 0, s + jarakKaki);
        vertices[116] = new Vector3(0, kakiHeight, jarakKaki);
        vertices[117] = new Vector3(0, kakiHeight, s + jarakKaki);
        vertices[118] = new Vector3(s, kakiHeight, jarakKaki);
        vertices[119] = new Vector3(s, kakiHeight, s + jarakKaki);
        vertices[120] = new Vector3(jarakKaki, 0, jarakKaki);
        vertices[121] = new Vector3(jarakKaki, 0, s + jarakKaki);
        vertices[122] = new Vector3(s + jarakKaki, 0, jarakKaki);
        vertices[123] = new Vector3(s + jarakKaki, 0, s + jarakKaki);
        vertices[124] = new Vector3(jarakKaki, kakiHeight, jarakKaki);
        vertices[125] = new Vector3(jarakKaki, kakiHeight, s + jarakKaki);
        vertices[126] = new Vector3(s + jarakKaki, kakiHeight, jarakKaki);
        vertices[127] = new Vector3(s + jarakKaki, kakiHeight, s + jarakKaki);

        // Duplikat-2
        vertices[128] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[129] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, s2 - lebarAlas);
        vertices[130] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[131] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas, s2 - lebarAlas);
        vertices[132] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas + sandaranHeight, 0 - lebarAlas);
        vertices[133] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas + sandaranHeight, s2 - lebarAlas);
        vertices[134] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + sandaranHeight, 0 - lebarAlas);
        vertices[135] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + sandaranHeight, s2 - lebarAlas);
        vertices[136] = new Vector3(s - s2 + jarakKaki + lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[137] = new Vector3(s - s2 + jarakKaki + lebarAlas, kakiHeight + tebalAlas, s2 - lebarAlas);
        vertices[138] = new Vector3(s  + jarakKaki + lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[139] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, s2 - lebarAlas);
        vertices[140] = new Vector3(s - s2 + jarakKaki + lebarAlas, kakiHeight + tebalAlas + sandaranHeight, 0 - lebarAlas);
        vertices[141] = new Vector3(s - s2 + jarakKaki + lebarAlas, kakiHeight + tebalAlas + sandaranHeight, s2 - lebarAlas);
        vertices[142] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + sandaranHeight, 0 - lebarAlas);
        vertices[143] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + sandaranHeight, s2 - lebarAlas);

        // Duplikat-3
        vertices[144] = new Vector3(0 - lebarAlas + masukanArm, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm);
        vertices[145] = new Vector3(0 - lebarAlas + masukanArm + s3, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm);
        vertices[146] = new Vector3(0 - lebarAlas + masukanArm, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[147] = new Vector3(0 - lebarAlas + masukanArm + s3, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[148] = new Vector3(0 - lebarAlas + masukanArm, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm);
        vertices[149] = new Vector3(0 - lebarAlas + masukanArm + s3, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm);
        vertices[150] = new Vector3(0 - lebarAlas + masukanArm, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[151] = new Vector3(0 - lebarAlas + masukanArm + s3, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[152] = new Vector3(s + jarakKaki + lebarAlas - masukanArm, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm);
        vertices[153] = new Vector3(s + jarakKaki + lebarAlas - masukanArm - s3, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm);
        vertices[154] = new Vector3(s + jarakKaki + lebarAlas - masukanArm, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[155] = new Vector3(s + jarakKaki + lebarAlas - masukanArm - s3, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[156] = new Vector3(s + jarakKaki + lebarAlas - masukanArm, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm);
        vertices[157] = new Vector3(s + jarakKaki + lebarAlas - masukanArm - s3, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm);
        vertices[158] = new Vector3(s + jarakKaki + lebarAlas - masukanArm, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[159] = new Vector3(s + jarakKaki + lebarAlas - masukanArm - s3, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas - masukanArm - s3);
        vertices[160] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + tinggiArm, s2 - lebarAlas);
        vertices[161] = new Vector3(s2 - lebarAlas - s4, kakiHeight + tebalAlas + tinggiArm, s2 - lebarAlas);
        vertices[162] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s2 - lebarAlas);
        vertices[163] = new Vector3(s2 - lebarAlas - s4, kakiHeight + tebalAlas + tinggiArm + tebalArm, s2 - lebarAlas);
        vertices[164] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + tinggiArm, s2 + lebarAlas + jarakKaki);
        vertices[165] = new Vector3(s2 - lebarAlas - s4, kakiHeight + tebalAlas + tinggiArm, s2 + lebarAlas + jarakKaki);
        vertices[166] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s2 + lebarAlas + jarakKaki);
        vertices[167] = new Vector3(s2 - lebarAlas - s4, kakiHeight + tebalAlas + tinggiArm + tebalArm, s2 + lebarAlas + jarakKaki);
        vertices[168] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + tinggiArm, s - lebarAlas);
        vertices[169] = new Vector3(s + jarakKaki - s4 + lebarAlas, kakiHeight + tebalAlas + tinggiArm, s - lebarAlas);
        vertices[170] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s - lebarAlas);
        vertices[171] = new Vector3(s + jarakKaki - s4 + lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s - lebarAlas);
        vertices[172] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas);
        vertices[173] = new Vector3(s + jarakKaki - s4 + lebarAlas, kakiHeight + tebalAlas + tinggiArm, s + jarakKaki + lebarAlas);
        vertices[174] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s + jarakKaki + lebarAlas);
        vertices[175] = new Vector3(s + jarakKaki - s4 + lebarAlas, kakiHeight + tebalAlas + tinggiArm + tebalArm, s + jarakKaki + lebarAlas);

        // Duplikat-4
        vertices[176] = new Vector3(0 - lebarAlas, kakiHeight, 0 - lebarAlas);
        vertices[177] = new Vector3(s + lebarAlas + jarakKaki, kakiHeight, 0 - lebarAlas);
        vertices[178] = new Vector3(0 - lebarAlas, kakiHeight, s + jarakKaki + lebarAlas);
        vertices[179] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight, s + jarakKaki + lebarAlas);
        vertices[180] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[181] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, 0 - lebarAlas);
        vertices[182] = new Vector3(0 - lebarAlas, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas);
        vertices[183] = new Vector3(s + jarakKaki + lebarAlas, kakiHeight + tebalAlas, s + jarakKaki + lebarAlas);

        // Duplikat-5
        vertices[184] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas - turunanSandaran + sandaranHeight, 0 - lebarAlas);
        vertices[185] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas - turunanSandaran + sandaranHeight, s2 - lebarAlas);
        vertices[186] = new Vector3(s + jarakKaki - s2 + lebarAlas, kakiHeight + tebalAlas - turunanSandaran + sandaranHeight, 0 - lebarAlas);
        vertices[187] = new Vector3(s + jarakKaki - s2 + lebarAlas, kakiHeight + tebalAlas - turunanSandaran + sandaranHeight, s2 - lebarAlas);
        vertices[188] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas - lebarSandaran - turunanSandaran + sandaranHeight, 0 - lebarAlas);
        vertices[189] = new Vector3(s2 - lebarAlas, kakiHeight + tebalAlas - lebarSandaran - turunanSandaran + sandaranHeight, s2 - lebarAlas);
        vertices[190] = new Vector3(s + jarakKaki - s2 + lebarAlas, kakiHeight + tebalAlas - lebarSandaran - turunanSandaran + sandaranHeight, 0 - lebarAlas);
        vertices[191] = new Vector3(s + jarakKaki - s2 + lebarAlas, kakiHeight + tebalAlas - lebarSandaran - turunanSandaran + sandaranHeight, s2 - lebarAlas);

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            // Segitiga untuk kaki kursi
            2, 1, 0,
            1, 2, 3,
            4, 5, 6,
            7, 6, 5,
            96+6, 96+2, 96+0,
            96+0, 96+4, 96+6,
            7, 3, 2,
            2, 6, 7,
            96+5, 96+1, 96+3,
            96+7, 96+5, 96+3,
            0, 1, 4,
            1, 5, 4,
            10, 9, 8,
            9, 10, 11,
            12, 13, 14,
            15, 14, 13,
            96+14, 96+10, 96+8,
            96+8,  96+12, 96+14,
            15, 11, 10,
            10, 14, 15,
            96+13, 96+9, 96+11,
            96+15, 96+13, 96+11,
            8, 9, 12,
            9, 13, 12,
            18, 17, 16,
            17, 18, 19,
            20, 21, 22,
            23, 22, 21,
            96+22, 96+18, 96+16,
            96+16, 96+20, 96+22,
            23, 19, 18,
            18, 22, 23,
            96+21, 96+17, 96+19,
            96+23, 96+21, 96+19,
            16, 17, 20,
            17, 21, 20,
            26, 25, 24,
            25, 26, 27,
            28, 29, 30,
            31, 30, 29,
            96+30, 96+26, 96+24,
            96+24, 96+28, 96+30,
            31, 27, 26,
            26, 30, 31,
            96+29, 96+25, 96+27,
            96+31, 96+29, 96+27,
            24, 25, 28,
            25, 29, 28,
            
            // Segitiga untuk alas kursi
            144+32, 144+33, 144+34,
            144+35, 144+34, 144+33,
            144+38, 144+37, 144+36,
            144+37, 144+38, 144+39,
            144+36, 144+33, 144+32,
            144+33, 144+36, 144+37,
            39, 35, 33,
            33, 37, 39,
            144+38, 144+34, 144+35,
            144+35, 144+39, 144+38,
            32, 34, 38,
            38, 36, 32,

            // Segitiga untuk Penyangga Sandaran Kursi
            88+44, 88+45, 88+46,
            88+47, 88+46, 88+45,
            46, 42, 40,
            40, 44, 46,
            88+47, 88+43, 88+42,
            88+42, 88+46, 88+47,
            45, 41, 43,
            47, 45, 43,
            88+40, 88+41, 88+44,
            88+41, 88+45, 88+44,
            88+52, 88+53, 88+54,
            88+55, 88+54, 88+53,
            54, 50, 48,
            48, 52, 54,
            88+55, 88+51, 88+50,
            88+50, 88+54, 88+55,
            53, 49, 51,
            55, 53, 51,
            88+48, 88+49, 88+52,
            88+49, 88+53, 88+52,

            // Segitiga untuk sandaran kursi
            128+56, 128+57, 128+58,
            128+59, 128+58, 128+57,
            128+62, 128+61, 128+60,
            128+61, 128+62, 128+63,
            56, 58, 60,
            62, 60, 58,
            59, 61, 63,
            61, 59, 57,
            
            // Segitiga untuk armrest
            64, 65, 66,     
            67, 66, 65,
            71, 70, 69,
            68, 69, 70,
            80+70, 80+66, 80+64,
            80+64, 80+68, 80+70,
            71, 67, 66,
            66, 70, 71,
            80+69, 80+65, 80+67,
            80+71, 80+69, 80+67,
            64, 65, 68,
            65, 69, 68,
            74, 73, 72,     
            73, 74, 75,
            77, 78, 79,
            78, 77, 76,
            80+72, 80+74, 80+78,
            80+78, 80+76, 80+72,
            74, 75, 79,
            79, 78, 74,
            80+75, 80+73, 80+77,
            80+75, 80+77, 80+79,
            76, 73, 72,
            76, 77, 73,
            80+86, 80+85, 80+84,
            80+85, 80+86, 80+87,
            80+80, 80+82, 80+86,
            80+86, 80+84, 80+80,
            82, 83, 87,
            87, 86, 82,
            80+83, 80+81, 80+85,
            80+83, 80+85, 80+87,
            84, 81, 80,
            84, 85, 81,
            80+94, 80+93, 80+92,
            80+93, 80+94, 80+95,
            80+88, 80+90, 80+94,
            80+94, 80+92, 80+88,
            90, 91, 95,
            95, 94, 90,
            80+91, 80+89, 80+93,
            80+91, 80+93, 80+95,
            92, 89, 88,
            92, 93, 89,
        };

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
        for(int i=64; i<96; i += 8){
            uvs[i] = new Vector2(0.0f, 0.0f);
            uvs[i+1] = new Vector2(0.0f, 1.0f);
            uvs[i+2] = new Vector2(0.5f, 0.0f);
            uvs[i+3] = new Vector2(0.5f, 1.0f);
            uvs[i+4] = new Vector2(0.5f, 0.0f);
            uvs[i+5] = new Vector2(0.5f, 1.0f);
            uvs[i+6] = new Vector2(0.0f, 0.0f);
            uvs[i+7] = new Vector2(0.0f, 1.0f);   
        }
        for(int i=96; i<128; i += 8){
            uvs[i] = new Vector2(0.0f, 1.0f); 
            uvs[i+1] = new Vector2(0.0f, 1.0f); 
            uvs[i+2] = new Vector2(0.0f, 0.0f);
            uvs[i+3] = new Vector2(0.0f, 0.0f);
            uvs[i+4] = new Vector2(0.5f, 1.0f);
            uvs[i+5] = new Vector2(0.5f, 1.0f);
            uvs[i+6] = new Vector2(0.5f, 0.0f);
            uvs[i+7] = new Vector2(0.5f, 0.0f);
        }
        for(int i=128; i<144; i += 8){
            uvs[i] = new Vector2(0.0f, 0.0f);
            uvs[i+1] = new Vector2(0.0f, 1.0f);
            uvs[i+2] = new Vector2(0.5f, 0.0f);
            uvs[i+3] = new Vector2(0.5f, 1.0f);
            uvs[i+4] = new Vector2(0.5f, 0.0f);
            uvs[i+5] = new Vector2(0.5f, 1.0f);
            uvs[i+6] = new Vector2(0.0f, 0.0f);
            uvs[i+7] = new Vector2(0.0f, 1.0f);   
        }
        for(int i=144; i<176; i += 8){
            uvs[i] = new Vector2(0.0f, 1.0f); 
            uvs[i+1] = new Vector2(0.0f, 1.0f); 
            uvs[i+2] = new Vector2(0.0f, 0.0f);
            uvs[i+3] = new Vector2(0.0f, 0.0f);
            uvs[i+4] = new Vector2(0.5f, 1.0f);
            uvs[i+5] = new Vector2(0.5f, 1.0f);
            uvs[i+6] = new Vector2(0.5f, 0.0f);
            uvs[i+7] = new Vector2(0.5f, 0.0f);
        }
        for(int i=176; i<183; i += 8){
            uvs[i] = new Vector2(0.0f, 0.0f);
            uvs[i+1] = new Vector2(0.0f, 1.0f);
            uvs[i+2] = new Vector2(0.5f, 0.0f);
            uvs[i+3] = new Vector2(0.5f, 1.0f);
            uvs[i+4] = new Vector2(0.5f, 0.0f);
            uvs[i+5] = new Vector2(0.5f, 1.0f);
            uvs[i+6] = new Vector2(0.0f, 0.0f);
            uvs[i+7] = new Vector2(0.0f, 1.0f);   
        }
        for(int i=184; i<192; i += 8){
            uvs[i] = new Vector2(0.0f, 0.0f);
            uvs[i+1] = new Vector2(0.0f, 1.0f);
            uvs[i+2] = new Vector2(0.5f, 0.0f);
            uvs[i+3] = new Vector2(0.5f, 1.0f);
            uvs[i+4] = new Vector2(0.5f, 0.0f);
            uvs[i+5] = new Vector2(0.5f, 1.0f);
            uvs[i+6] = new Vector2(0.0f, 0.0f);
            uvs[i+7] = new Vector2(0.0f, 1.0f);   
        }

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
