
using UnityEngine;
using UnityEngine.UI;

public class Slider1Value : MonoBehaviour
{
    // Start is called before the first frame update
    private Text textComp;
    private Slider slider;
    void Awake()
    {
        slider = GetComponentInParent<Slider>();
        textComp = GetComponent<Text>();
    }

    void Start(){
        UpdateText(slider.value);
        slider.onValueChanged.AddListener(UpdateText);
    }

    // Update is called once per frame
    void UpdateText(float val)
    {
        textComp.text = (slider.value/2).ToString();
    }
}
