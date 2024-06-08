using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public GameObject pipesHolder;
    public GameObject[] pipes;

    [SerializeField]
    int totalPipes = 0;

    [SerializeField]
    int correctedPipes = 0;

    void Start()
    {
        totalPipes = pipesHolder.transform.childCount;

        pipes = new GameObject[totalPipes];
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i] = pipesHolder.transform.GetChild(i).gameObject;
        }
    }

    public void correctMove()
    {
        correctedPipes += 1;

        if (correctedPipes == totalPipes)
        {
            Debug.Log("PUZZLE COMPLETED!");
        }
    }

    public void wrongMove()
    {
        correctedPipes -= 1;
    }
}