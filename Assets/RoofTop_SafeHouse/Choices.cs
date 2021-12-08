using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class Choices : MonoBehaviour
{
    // Start is called before the first frame update
     public void playTimeline(PlayableDirector playableDirector)
    {
        playableDirector.Play();
    }
}
