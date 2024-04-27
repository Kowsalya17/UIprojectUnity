using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour
{
    public TextMeshProUGUI currentbuttontext;

    public Button[] but;

    // Start is called before the first frame update
    void Start()
    {
        but[0].onClick.AddListener(() => stringchange("Quick Race"));
        but[1].onClick.AddListener(() => stringchange("Career"));
        but[2].onClick.AddListener(() => stringchange("Setting"));
        but[3].onClick.AddListener(() => stringchange("Back"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuickRace()
    {
        currentbuttontext.text = "QuickRace";
    }
    public void Career()
    {
        currentbuttontext.text = "Carrer";
    }
    public void Setting()
    {
        currentbuttontext.text = "Setting";
    }
    public void Back()
    {
        currentbuttontext.text = "Back";
    }

    public void stringchange(string changetext)
    {
        currentbuttontext.text = changetext;
    }


}
