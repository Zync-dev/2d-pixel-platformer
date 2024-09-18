using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{

    public List<GameObject> segments;
    public float segmentLength = 18f;
    float currentSegmentSpawnLocation = 0;
    public float spawnDistance = 100f;
    public GameObject playerModel;

    GameObject tileGrid;

    void Start()
    {
        tileGrid = GameObject.FindGameObjectWithTag("TileGrid");
    }

    void Update()
    {
        if (playerModel != null && segments != null)
        {
            if (playerModel.transform.position.x >= currentSegmentSpawnLocation - spawnDistance)
            {
                int rndSegment = Random.Range(0, segments.Count);

                GameObject spawnedSegment = Instantiate(segments[rndSegment], tileGrid.transform);
                spawnedSegment.transform.position = new Vector3(currentSegmentSpawnLocation, 0f, 0f);
                currentSegmentSpawnLocation += segmentLength;
            }
        }
    }
}
