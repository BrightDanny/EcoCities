using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpawn : MonoBehaviour
{
    public Vector3 curPos;

    public int areaAmount;
    public int rows;

    public int totalArea;

    //spriterenderer layer order
    public int layer;

    //offsets
    public float xOffset;
    public float yOffset;

    //set the delay between spawns
    public float spawnSpeed;



    void Start()
    {
        StartCoroutine("Spawn");
    }


    IEnumerator Spawn()
    {

        curPos = transform.position;
        totalArea = rows * areaAmount;

        layer++;
        //Vertical
        for (int row = 0; row < rows; row++)
        {
            for (int i = 0; i < areaAmount; i++)
            {
                yield return new WaitForSeconds(spawnSpeed);
                GameObject _area = Instantiate(Resources.Load("BuildArea") as GameObject);
                _area.transform.position = curPos;
                _area.transform.parent = gameObject.transform;
                curPos = new Vector3(curPos.x + xOffset, curPos.y + yOffset, 0);
                _area.GetComponentInChildren<SpriteRenderer>().sortingOrder = layer;
                layer++;
            }
            curPos = new Vector3(curPos.x - xOffset * areaAmount, curPos.y - yOffset * areaAmount, 0);

            curPos = new Vector3(curPos.x + xOffset, curPos.y - yOffset, 0);
        }
    }
}
