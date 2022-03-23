using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupInclineScript : MonoBehaviour
{

    public Animator inclineZeroAnim;
    public Image zeroDegreeButton;
   
    [TextArea]
    public string _text;
    
    public float _characterInterval;

    string _partialText;
    float _cumulativeDeltatime;
    public static bool _showObjective;
    
    public  bool introOff;
     bool switchOf;
   public  bool animOn;
    public bool animOff;
    public Image blinkImage;
    private Color buttonColor;
   







    Text _label;

    void Start()
    {
        StartText();
        _showObjective = false;
        buttonColor.a=0;

       
       
        
    }

    public void switchOff(){
       
       animOn=true;


    }

    void Awake()
    {
        _label = GetComponent<Text>();
    }

    void StartText()
    {
        _partialText = "";
        _cumulativeDeltatime = 0;
    }

    void TypeWriteText()
    {
        _cumulativeDeltatime += Time.deltaTime;

        while (_cumulativeDeltatime >= _characterInterval &&
            _partialText.Length < _text.Length)
        {
            _partialText += _text[_partialText.Length];
            _cumulativeDeltatime -= _characterInterval;
        }

        _label.text = _partialText;
    }

    void EraseText()
    {
        _label.text = "";
        introOff=true;
       
        
    }

    // switch the animator on
    public void switchAnimOn()
    {
       
        //animOn = true;

    }

  
    

    void Update()
    {
        

        if(_partialText.Length < _text.Length){

          
           TypeWriteText();
        }else if(_partialText.Length ==_text.Length){

        
         Invoke("EraseText",7f);
        
          
        }
           
    // activate the button animator
    if(introOff)
        {
           inclineZeroAnim.enabled = true;
            zeroDegreeButton.raycastTarget = true;
        }
     //deactive the animator
        if(animOn)
        {
            inclineZeroAnim.enabled = false;
            blinkImage.color = buttonColor;

        }
    }


    
}
