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
    public AudioSource[] AudioSource;
    public GameObject[] decisions;
    public bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(decisions[0].activeSelf && !paused)
        {
            AudioSourceGamePlay.Pause();
            AudioSource[0].Play();
            paused = true;
            timelineHouse.playableGraph.GetRootPlayable(0).SetSpeed(0);
        }
    }

    public void PlayCaptainTalks()
    {
        paused = false;
        AudioSource[0].Stop();
        Debug.Log("Here Before");
        decisions[0].SetActive(false);
        Debug.Log("Here After");
        timelineCaptainTalks.Play();
    }
}
