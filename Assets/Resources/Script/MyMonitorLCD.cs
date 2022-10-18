using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMonitorLCD : MonoBehaviour
{
    [SerializeField]
    public Material chairMaterial;
    Texture myTexture;
    public float height = 5.0f;
    public float width = 8.0f;
    public float depth = 0.36f;
    public float textSumWidth = 3550.0f;
    public float textSumHeight = 1200.0f;
    public float textWidth = 1700.0f;
    public float textHeight = 1050.0f;
    public float textDepth = 75.0f;

    // Start is called before the first frame update
    void Start(){
        // Declaring and initializing values for our mesh
        Mesh mesh = new Mesh();
        var vertices = new Vector3[24];
        var uvs = new Vector2[vertices.Length];
        myTexture = Resources.Load<Texture>("Textures/carbon");

        // // Titik-titik tangkai monitor
        // vertices[0] = new Vector3(0, 2.25f, 0);
        // vertices[1] = new Vector3(0, 2.25f, 0.75f);
        // vertices[2] = new Vector3(9, 2.25f, 0);
        // vertices[3] = new Vector3(9, 2.25f, 0.75f);

        // vertices[4] = new Vector3(0, 6.25f, 0);
        // vertices[5] = new Vector3(0, 6.25f, 0.75f);
        // vertices[6] = new Vector3(9, 6.25f, 0);
        // vertices[7] = new Vector3(9, 6.25f, 0.75f);

        // rear surface
        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, height, 0);
        vertices[2] = new Vector3(width, height, 0);
        vertices[3] = new Vector3(width, 0, 0);

        uvs[0] = new Vector2(0.5f, textDepth / textSumHeight);
        uvs[1] = new Vector2(0.5f, (textDepth + textHeight) / textSumHeight);
        uvs[2] = new Vector2(0.5f + textWidth/textSumWidth, (textDepth + textHeight) / textSumHeight);
        uvs[3] = new Vector2(0.5f + textWidth/textSumWidth, textDepth / textSumHeight);

        // front surface
        vertices[4] = new Vector3(0, 0, depth);
        vertices[5] = new Vector3(0, height, depth);
        vertices[6] = new Vector3(width, height, depth);
        vertices[7] = new Vector3(width, 0, depth);

        uvs[4] = new Vector2(0.5f, textDepth / textSumHeight);
        uvs[5] = new Vector2(0.5f, (textDepth + textHeight) / textSumHeight);
        uvs[6] = new Vector2(0.5f - textWidth/textSumWidth, (textDepth + textHeight) / textSumHeight);
        uvs[7] = new Vector2(0.5f - textWidth/textSumWidth, textDepth / textSumHeight);

        // right surface
        vertices[8] = new Vector3(0, 0, 0);
        vertices[9] = new Vector3(0, height, 0);
        vertices[10] = new Vector3(0, height, depth);
        vertices[11] = new Vector3(0, 0, depth);

        uvs[8] = new Vector2(1.0f, textDepth / textSumHeight);
        uvs[9] = new Vector2(1.0f, (textDepth + textHeight) / textSumHeight);
        uvs[10] = new Vector2(1.0f - textDepth/textSumWidth, (textDepth + textHeight) / textSumHeight);
        uvs[11] = new Vector2(1.0f - textDepth/textSumWidth, textDepth / textSumHeight);

        // left surface
        vertices[12] = new Vector3(width, 0, 0);
        vertices[13] = new Vector3(width, height, 0);
        vertices[14] = new Vector3(width, height, depth);
        vertices[15] = new Vector3(width, 0, depth);

        uvs[12] = new Vector2(0.0f, textDepth / textSumHeight);
        uvs[13] = new Vector2(0.0f, (textDepth + textHeight) / textSumHeight);
        uvs[14] = new Vector2(0.0f + textDepth/textSumWidth, (textDepth + textHeight) / textSumHeight);
        uvs[15] = new Vector2(0.0f + textDepth/textSumWidth, textDepth / textSumHeight);

        // top surface
        vertices[16] = new Vector3(0, height, 0);
        vertices[17] = new Vector3(0, height, depth);
        vertices[18] = new Vector3(width, height, depth);
        vertices[19] = new Vector3(width, height, 0);

        uvs[16] = new Vector2(0.5f, 1.0f);
        uvs[17] = new Vector2(0.5f, 1.0f);
        uvs[18] = new Vector2(0.5f + textWidth/textSumWidth, 1.0f - textDepth/textSumHeight);
        uvs[19] = new Vector2(0.5f + textWidth/textSumWidth, 1.0f - textDepth/textSumHeight);

        // bottom surface
        vertices[20] = new Vector3(0, 0, 0);
        vertices[21] = new Vector3(0, 0, depth);
        vertices[22] = new Vector3(width, 0, depth);
        vertices[23] = new Vector3(width, 0, 0);

        uvs[20] = new Vector2(0.5f, 0.0f);
        uvs[21] = new Vector2(0.5f, 0.0f);
        uvs[22] = new Vector2(0.5f + textWidth/textSumWidth, 0.0f + textDepth/textSumHeight);
        uvs[23] = new Vector2(0.5f + textWidth/textSumWidth, 0.0f + textDepth/textSumHeight);
        
        

        // uvs[0] = new Vector2(0, 0);
        // uvs[1] = new Vector2(0, 0.137625f);
        // uvs[2] = new Vector2(0.481278605007559f, 0);
        // uvs[3] = new Vector2(0.481278605007559f, 0.137625f);

        // uvs[4] = new Vector2(0.25f, 0.137625f);
        // uvs[5] = new Vector2(0.5f, 0.5f);
        // uvs[6] = new Vector2(0.25f, 0.0f);
        // uvs[7] = new Vector2(0.5f, 0.0f);

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            0, 1, 2,
            2, 3, 0,

            6, 5, 4,
            4, 7, 6,

            10, 9, 8,
            8, 11, 10,

            12, 13, 14,
            14, 15, 12,

            16, 17, 18,
            18, 19, 16,

            22, 21, 20,
            20, 23, 22

            // 2, 1, 0,
            // 1, 2, 3,

            // 4, 5, 6,
            // 7, 6, 5,

            // 6, 2, 0,
            // 0, 4, 6,

            // 7, 3, 2,
            // 2, 6, 7,

            // 5, 1, 3,
            // 7, 5, 3,
            
            // 0, 1, 4,
            // 1, 5, 4,
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
