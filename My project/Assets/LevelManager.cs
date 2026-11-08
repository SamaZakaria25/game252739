using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject CurrentCheckPoint;

    void Start()
    {
        CurrentCheckPoint = null;
    }

    public void RespawnPlayer()
    {
        FindObjectOfType<playerController>().transform.position = CurrentCheckPoint.transform.position;
    }
}