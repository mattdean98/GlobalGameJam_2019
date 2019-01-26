using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    Node[] PathNode;

    public GameObject Guard1;
    public float MoveSpeed;

    float Timer;

    int CurrentNode;
    static Vector3 CurrentPositionHolder;




    // Start is called before the first frame update
    void Start()
    {
        PathNode = GetComponentsInChildren<Node>();
        CheckNode();

        //foreach(var i in PathNode)
        //{
        //    Debug.Log(i.name);
        //}
    }

    void CheckNode()
    {
        Timer = 0;
        if (PathNode[CurrentNode] != null)
        {
            CurrentPositionHolder = PathNode[CurrentNode].transform.position;
        }
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(CurrentNode);
        Timer += Time.deltaTime * MoveSpeed;

        if(Guard1.transform.position != CurrentPositionHolder)
        {
            Guard1.transform.position = Vector3.Lerp(Guard1.transform.position, CurrentPositionHolder, Timer);
        }
        else
        {
            CurrentNode++;
            CheckNode();
        }
    }
}
