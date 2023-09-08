using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rezulte : MonoBehaviour
{
    public string result, name;
    public TMP_InputField hideanswer;
    public TMP_Text ruzzz;
    StreamReader sr;
    public void rez()
    {
        if (File.Exists("User " + hideanswer.text + ".txt"))
        {
            sr = new StreamReader("User " + hideanswer.text + ".txt");
            ruzzz.text = "";
            name = sr.ReadLine();
            while (name!= null) 
            {
                if (name.Length > 5)
                {
                    
                    if (name[0] == '!' && name[1] == '_' && name[2] == '_' && name[3] == '_'  && name[4] == '!')
                    {
                        Debug.Log("AAAAAAA");
                        for (int i = 5; i < name.Length; i++)
                        {
                            ruzzz.text += name[i];
                        }
                    }
                }
                name = sr.ReadLine();
            }
            sr.Close();

        }
        else
        {
            hideanswer.text = "Пользователь не найден";
        }
        
    }
    

}
