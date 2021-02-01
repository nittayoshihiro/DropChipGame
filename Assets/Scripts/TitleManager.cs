using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TitleManager : MonoBehaviour
{
    [SerializeField] PlayableDirector m_director = null;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Skip();
        }
    }

    void Skip()
    {
        Debug.Log("Timeline Stopped.");
        //playableDirector.playableGraph.GetRootPlayable(0).SetSpeed(speed)
        m_director.playableGraph.GetRootPlayable(0).SetSpeed(60);
    }
}
