    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze2 : MonoBehaviour
{
    [Header("Constraints:")]
    public int width = 30;
    public int depth = 30;
    public byte[,] map;


    // Start is called before the first frame update
    void Start()
    {
        InitialiseMap();
        Generate();
        DrawMap();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void InitialiseMap()
    {
        map = new byte[width, depth];
        for (int z = 0; z < width; z++)
            for (int x = 0; x < width; x++)
            {
                    map[x, z] = 1;
            }
    }

    void Generate()
    {
        for (int z = 0; z < width; z++)
            for (int x = 0; x < width; x++)
            {
                if (Random.Range(0, 100) < 50)
                {
                    map[x, z] = 0;
                }
            }
    }

    void DrawMap()
    {
        for (int z = 0; z < width; z++)
            for (int x = 0; x < width; x++)
            {
                if (map[x,z] == 1)
                {
                    Vector3 pos = new Vector3(x, 0, z);
                    GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    wall.transform.position = pos;
                }
            }
    }

    public IEnumerator PauseGen()
    {
        yield return new WaitForSeconds(1);
    }
}
