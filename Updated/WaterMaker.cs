using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMaker : MonoBehaviour
{

    [SerializeField] int waterLength = 50;
    [SerializeField] int waterWidth = 50;
    Vector4[,] water;
    Mesh waterMesh;
    Vector3[] vertices;
    [SerializeField, Range(0, 1)] float damping = 0.1f;
    [SerializeField, Range(0, 100)] float waveSpeed = 10;

    void Start()
    {
        MakeWater();
        MakeWaterMesh();
    }

    void Update()
    {
        UpdateWater();
        UpdateMesh();
    }

    void MakeWaterMesh()
    {
        List<Vector3> verticies = new List<Vector3>();
        foreach (Vector4 point in water)
        {
            verticies.Add((Vector3)point);
        }
        waterMesh = new Mesh();
        waterMesh.MarkDynamic();
        waterMesh.name = "Water Mesh";
        List<int> triangles = new List<int>();
        for (int i = 0; i < waterLength - 1; i++)
        {
            for (int j = 0; j < waterWidth - 1; j++)
            {
                triangles.Add(i * waterWidth + j);
                triangles.Add(i * waterWidth + j + 1);
                triangles.Add((i + 1) * waterWidth + j);
            }
        }
        for (int i = 1; i < waterLength; i++)
        {
            for (int j = 1; j < waterWidth; j++)
            {
                triangles.Add(i * waterWidth + j);
                triangles.Add(i * waterWidth + j - 1);
                triangles.Add((i - 1) * waterWidth + j);
            }
        }

        waterMesh.vertices = verticies.ToArray();
        vertices = verticies.ToArray();
        waterMesh.triangles = triangles.ToArray();
        waterMesh.RecalculateNormals();
        waterMesh.RecalculateBounds();
        GetComponent<MeshFilter>().mesh = waterMesh;
    }

    void MakeWater()
    {
        water = new Vector4[waterLength, waterWidth];
        for (int i = 0; i < waterLength; i++)
        {
            for (int j = 0; j < waterWidth; j++)
            {
                water[i, j] = new Vector4(i, 0, j, 0);
            }
        }
    }

    void UpdateWater()
    {
        for (int i = 1; i < waterLength - 1; i++)
        {
            for (int j = 1; j < waterWidth - 1; j++)
            {
                water[i, j].w -= ((water[i, j].y - water[i - 1, j].y)
                    + (water[i, j].y - water[i + 1, j].y)
                    + (water[i, j].y - water[i, j - 1].y)
                    + (water[i, j].y - water[i, j + 1].y)) * Time.deltaTime * waveSpeed;
            }
        }
        for (int i = 0; i < waterLength; i++)
        {
            for (int j = 0; j < waterWidth; j++)
            {
                water[i, j].w *= Mathf.Pow((1 - damping), Time.deltaTime);
                water[i, j].y += water[i, j].w * Time.deltaTime;
            }
        }
    }

    void UpdateMesh()
    {
        for (int i = 0; i < waterLength; i++)
        {
            for (int j = 0; j < waterWidth; j++)
            {
                vertices[i * waterWidth + j] = (Vector3)water[i, j];
            }
        }
        waterMesh.vertices = vertices;
    }

    public void MoveVertix(int x, int z, float amount)
    {
        water[x, z].y += amount;
    }
}