using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PrintTotal : MonoBehaviour
{
    public TMP_Text total;
    public static TMP_Text otal;
    void Start()
    {
        total.text = (Convert.ToString(Answer.GetFinalAnswer) + " �� " + Convert.ToString(Answer.GetRightAnswer));

    }
    public static void chet()
    {
        otal.text = (Convert.ToString(Answer.rrr) + " �� " + Convert.ToString(Answer.GetRightAnswer));
    }

}
