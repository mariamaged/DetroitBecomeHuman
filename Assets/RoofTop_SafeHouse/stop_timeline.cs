using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class stop_timeline : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public void playTimeline()
    {
        playableDirector.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}