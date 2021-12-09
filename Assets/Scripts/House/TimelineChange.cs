using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;
using UnityEngine.UI;
public class TimelineChange : MonoBehaviour
{

    public PlayableDirector timelineCaptainTalks;
    public PlayableDirector timelineHouse;
    public AudioSource AudioSourceGamePlay;
    public AudioClip clip;
    public GameObject[] decisions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(decisions[0].activeSelf)
        {
            AudioSourceGamePlay.clip = clip;
            AudioSourceGamePlay.playOnAwake = false;
            AudioSourceGamePlay.Play();
            timelineHouse.playableGraph.GetRootPlayable(0).SetSpeed(0);
        }
    }

    public void PlayCaptainTalks()
    {
        timelineCaptainTalks.Play();
        decisions[0].SetActive(false);
    }
}
