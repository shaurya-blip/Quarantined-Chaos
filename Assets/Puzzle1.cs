using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Puzzle1 : MonoBehaviour
{
    public Slider acidslider;
    public Slider basicslider;
    public Text textComp;
    public GameObject nextlevel;
    public GameObject timer;
    public string s;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float acid = acidslider.value/2;
        float basey = basicslider.value/2;
        DetermineProductAcidity(acid, basey);
        textComp.text = s;
    }

    void DetermineProductAcidity(double ph1, double ph2)
    {
        // Check for invalid pH values (outside 0-14 range)
        if (ph1 < 0 || ph1 > 14 || ph2 < 0 || ph2 > 14)
        {
            s = "Invalid pH value(s). pH must be between 0 and 14.";
        }
        double averagePh = (ph1 + ph2) / 2;
        if (averagePh < 7)
        {
            s = "Acidic";
            nextlevel.SetActive(false);
        }
        else if (averagePh > 7)
        {
            s = "Basic";
            nextlevel.SetActive(false);
        }
        else
        {
            s = "Neutral! You can proceed to next level";
            nextlevel.SetActive(true);
        }
    }

    public void NextLevel(){
        SceneManager.LoadSceneAsync(2);
        DontDestroyOnLoad (timer);
    }
}
