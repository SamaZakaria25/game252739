using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
      public CurrentCheckPoint;
    // Start is called before the first frame update
    void Start()
    {
        CurrentCheckPoint = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnPlayer()
    {
        FindObjectOfType<playerController>().transform.position = CurrentCheckPoint.transform.position;
    }
}
