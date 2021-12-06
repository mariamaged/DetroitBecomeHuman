using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;
public class TimelineChange : MonoBehaviour
{

    public PlayableDirector timelineCaptainTalks;
    public PlayableDirector timelineHouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayCaptainTalks()
    {
        timelineHouse.Stop();
        timelineCaptainTalks.Play();
    }
}
