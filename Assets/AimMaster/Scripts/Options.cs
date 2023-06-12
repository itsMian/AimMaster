using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public Slider sensSlider;
    public InputField sensDisplay;
    public Text sensInputText;

    float sensInput;
    void Start()
    {
        sensInput = PlayerController.mouseSensitivity; 
        sensSlider.value = PlayerController.mouseSensitivity;
    }

    void Update()
    {
        sensDisplay.text = sensSlider.value.ToString();
        SensInput();
    }
    public void SensInput()
    {
        //sensInputText.text = sensDisplay.text;
        sensInput = float.Parse(sensInputText.text);
        sensDisplay.text = sensInput.ToString();
        sensSlider.value = sensInput;
    }
}
