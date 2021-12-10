using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class TimelineSelect : MonoBehaviour
{

    public PlayableDirector withGun;
    public PlayableDirector withoutGun;
    // Start is called before the first frame update
    void Start()
    {
        if (TimelineChange.TOOK_GUN)
        {
            withGun.Play();
        }
        else
        {
            withoutGun.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
