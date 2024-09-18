using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{

    public List<GameObject> segments;
    public float segmentLength;
    float currentSegmentSpawnLocation = 0;
    public GameObject playerModel;

    void Update()
    {
        if(playerModel.transform.position.x >= currentSegmentSpawnLocation-20)
        {
            int rndSegment = Random.Range(0,segments.Count - 1);

            GameObject spawnedSegment = Instantiate(segments[rndSegment]);
            spawnedSegment.transform.position = new Vector3(currentSegmentSpawnLocation, 0f, 0f);
            currentSegmentSpawnLocation += segmentLength;
        }
    }
}
