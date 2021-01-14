using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crawler : Maze
{
    [Header("Customisable Properties:")]
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
        int x = Random.Range(1, width -1);
        int z = 1;

        while (!done)
        {
            map[x, z] = 0;
            if (Random.Range(0, 100) < 50)
                x += Random.Range(-1, 2);
            else
                z += Random.Range(0, 2);
            done |= (x < 1 || x >= width -1 || z < 1 || z >= depth -1);
        }
    }

    public void CrawlH()
    {
        bool done = false;
        int x = 1;
        int z = Random.Range(1, depth -1);

        while (!done)
        {
            map[x, z] = 0;
            if (Random.Range(0, 100) < 50)
                x += Random.Range(0, 2);
            else
                z += Random.Range(-1, 2);
            done |= (x < 1 || x >= width -1 || z < 1 || z >= depth -1);
        }
    }
}
