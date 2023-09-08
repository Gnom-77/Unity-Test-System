using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    public GameObject buttonchange;
    public void ChangeColor()
    {
        //bool chek = false;

        if (buttonchange.GetComponent<Image>().color == Color.yellow)
        {
            buttonchange.GetComponent<Image>().color = Color.white; // chek = true;
            Answer.Number_Of_Responses += 1;
        }
        else
        {
            if (Answer.Number_Of_Responses > 0)
            {
                buttonchange.GetComponent<Image>().color = Color.yellow;
                Answer.Number_Of_Responses -= 1;
            }
        }
    }
    public void ChangeColorTeacher()
    {
        //bool chek = false;

        if (buttonchange.GetComponent<Image>().color == Color.green)
        {
            buttonchange.GetComponent<Image>().color = Color.white; // chek = true;
            CreatNewAccaunt.hideteacheranswer -= 1;
        }
        else
        {

            buttonchange.GetComponent<Image>().color = Color.green;
            CreatNewAccaunt.hideteacheranswer += 1;

        }
    }
}
