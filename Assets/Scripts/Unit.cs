using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private IAstarAI _astarAI;

    // Start is called before the first frame update
    void Start()
    {
        _astarAI = GetComponent<IAstarAI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateAIDestination(Vector3 v)
    {
        _astarAI.destination = v;
    }
}
