using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject play;
    public GameObject quit;
    public GameObject story;

    public void ButtonPress(){
        play.SetActive(false);
        quit.SetActive(false);
        story.SetActive(true);
    }
}
