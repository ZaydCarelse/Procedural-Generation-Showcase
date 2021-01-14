using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crawler2 : Maze
{
    [Header("Customisable Properties:")]
    [SerializeField]
    public float Vnum = 1f;
    public float Hnum = 1f;

    public override void Generate()
    {
        Vnum = S4VSlider.instance.vNum;
        Hnum = S4HSlider.instance.hNum;

        for (int i = 0; i < Vnum; i++)
        {
            CrawlV();
        }
        for (int i = 0; i < Hnum; i++)
        {
            CrawlH();
        }

    }

    public void CrawlV()
    {
        bool done = false;
        int x = Random.Range(0, width);
        int z = 0;

        while (!done)
        {
            map[x, z] = 0;
            if (Random.Range(0, 100) < 50)
                x += Random.Range(-1, 2);
            else
                z += Random.Range(0, 2);
            done |= (x < 0 || x >= width || z < 0 || z >= depth);
        }
    }

    public void CrawlH()
    {
        bool done = false;
        int x = 0;
        int z = Random.Range(0, depth);

        while (!done)
        {
            map[x, z] = 0;
            if (Random.Range(0, 100) < 50)
                x += Random.Range(0, 2);
            else
                z += Random.Range(-1, 2);
            done |= (x < 0 || x >= width || z < 0 || z >= depth);
        }
    }
}
