using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;


public class Choices : MonoBehaviour
{
    // Start is called before the first frame update
     public void playTimeline(PlayableDirector playableDirector)
    {
        playableDirector.Play();
    }
    public void restart()
    {
        SceneManager.LoadScene("House");

    }
}
