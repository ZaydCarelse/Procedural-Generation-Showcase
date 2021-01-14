    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze1 : MonoBehaviour
{
    public GameObject cube;

    [Header("Constraints:")]
    public int width = 30;
    public int depth = 30;


    // Start is called before the first frame update
    void Start()
    {
        for (int z = 0; z < width; z++)
            for (int x = 0; x < width; x++)
            {
                Vector3 pos = new Vector3(x, 0, z);
                Instantiate(cube, pos, Quaternion.identity);
            }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator PauseGen()
    {
        yield return new WaitForSeconds(1);
    }
}
