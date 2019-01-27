using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    Node[] PathNode;

    public GameObject Guard;
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
        _startPosition = Guard.transform.position;
        Timer = 0;
        if (CurrentNode >= PathNode.Length)
        {
            CurrentNode = 0;
        }
        CurrentPositionHolder = PathNode[CurrentNode].transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        try
        {
            //Debug.Log(CurrentNode);
            Timer += Time.deltaTime * MoveSpeed;

            if (Guard.transform.position != CurrentPositionHolder)
            {
                //TODO this doesnt work AT ALL -- SUPER JEEAAIEIENNNNKY
                //Guard1.transform.LookAt((PathNode[CurrentNode].transform.position + Guard1.transform.position)/2);
                Guard.transform.position = Vector3.Lerp(_startPosition, CurrentPositionHolder, Timer);

            }
            else
            {
                var between = new Vector3();
                if (CurrentNode == 0)
                {
                    between = Guard.transform.position - PathNode[1].transform.position;
                }
                else if (CurrentNode <= PathNode.Length)
                {
                    between = Guard.transform.position - PathNode[0].transform.position;
                }
                else
                {
                    between = Guard.transform.position - PathNode[CurrentNode].transform.position;
                }
                between = Quaternion.Euler(0, 180, 0) * between;

                Debug.Log("Between: " + between);
                Guard.transform.rotation = Quaternion.LookRotation(between);
                CurrentNode++;
                CheckNode();
            }
        }
        catch
        {

        }
    }

    IEnumerator WaitForSeconds(int n)
    {
        yield return new WaitForSeconds(n);
    }
}
