using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PathfindingRotate : MonoBehaviour
{
    public AIPath aipath;
    

    // Update is called once per frame
    void Update()
    {
        if (aipath.desiredVelocity.x <= 0.01)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aipath.desiredVelocity.x >= 0.01)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

    }
}
