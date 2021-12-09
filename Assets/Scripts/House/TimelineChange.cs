using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;
using UnityEngine.UI;
public class TimelineChange : MonoBehaviour
{

    public PlayableDirector timelineCaptainTalks;
    public PlayableDirector timelineSkipsCaptain;
    public PlayableDirector timelineHouse;
    public PlayableDirector timelineTakesGun;
    public PlayableDirector timelineSkipsGun;
    public AudioSource AudioSourceGamePlay;
    public AudioSource[] AudioSource;
    public Image[] decisions;
    public bool paused = false;
    public static bool TOOK_GUN;
    public static bool TALKED_TO_CAPTAIN;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(decisions[0].gameObject.activeSelf && !paused)
        {
            AudioSourceGamePlay.Pause();
            AudioSource[0].Play();
            paused = true;
            timelineHouse.playableGraph.GetRootPlayable(0).SetSpeed(0);
        }

        if (decisions[1].gameObject.activeSelf && !paused)
        {
            AudioSourceGamePlay.Pause();
            AudioSource[1].Play();
            paused = true;
            if(TALKED_TO_CAPTAIN) timelineCaptainTalks.playableGraph.GetRootPlayable(0).SetSpeed(0);
            else timelineSkipsCaptain.playableGraph.GetRootPlayable(0).SetSpeed(0);
        }
    }

    public void PlayCaptainTalks()
    {
        paused = false;
        TALKED_TO_CAPTAIN = true;
        AudioSource[0].Stop();
        timelineHouse.Stop();
        decisions[0].gameObject.SetActive(false);
        timelineCaptainTalks.Play();
    }

    public void PlaySkipCaptain()
    {
        paused = false;
        TALKED_TO_CAPTAIN = false;
        AudioSource[0].Stop();
        timelineHouse.Stop();
        decisions[0].gameObject.SetActive(false);
        timelineSkipsCaptain.Play();
    }

    public void PlayTakesGun()
    {
        paused = false;
        TOOK_GUN = true;
        AudioSource[1].Stop();
        if (TALKED_TO_CAPTAIN) timelineCaptainTalks.Stop();
        else timelineSkipsCaptain.Stop();
        decisions[1].gameObject.SetActive(false);
        timelineTakesGun.Play();
    }

    public void PlaySkipsGun()
    {
        paused = false;
        TOOK_GUN = false;
        AudioSource[1].Stop();
        if (TALKED_TO_CAPTAIN) timelineCaptainTalks.Stop();
        else timelineSkipsCaptain.Stop();
        decisions[1].gameObject.SetActive(false);
        timelineSkipsGun.Play();
    }
}
