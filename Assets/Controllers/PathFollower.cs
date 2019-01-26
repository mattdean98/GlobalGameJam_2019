﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    Node[] PathNode;

    public GameObject Guard1;
    private GameObject Light;

    public float MoveSpeed;

    float Timer;

    int CurrentNode;
    static Vector3 CurrentPositionHolder;
    private Vector3 _startPosition;




    // Start is called before the first frame update
    void Start()
    {
        PathNode = GetComponentsInChildren<Node>();
        CheckNode();

        //var temp = GetComponentInChildren();

        //foreach(var i in PathNode)
        //{
        //    Debug.Log(i.name);
        //}
    }

    void CheckNode()
    {
        _startPosition = Guard1.transform.position;
        Timer = 0;
        if (PathNode[CurrentNode] != null)
        {
            CurrentPositionHolder = PathNode[CurrentNode].transform.position;
        }
        else
        {
            //set to first node
            CurrentNode = 0;
        }
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(CurrentNode);
        Timer += Time.deltaTime * MoveSpeed;

        if(Guard1.transform.position != CurrentPositionHolder)
        {
            //TODO this doesnt work AT ALL -- SUPER JEEAAIEIENNNNKY
            //Guard1.transform.LookAt((PathNode[CurrentNode].transform.position + Guard1.transform.position)/2);
            Guard1.transform.position = Vector3.Lerp(_startPosition, CurrentPositionHolder, Timer);
            
        }
        else
        {
            CurrentNode++;
            CheckNode();
        }
    }

    IEnumerator WaitForSeconds(int n)
    {
        yield return new WaitForSeconds(n);
    }
}
