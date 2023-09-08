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
        total.text = (Convert.ToString(Answer.GetFinalAnswer) + " из " + Convert.ToString(Answer.GetRightAnswer));

    }
    public static void chet()
    {
        otal.text = (Convert.ToString(Answer.rrr) + " из " + Convert.ToString(Answer.GetRightAnswer));
    }

}
