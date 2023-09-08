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


public class ShowAllTest : MonoBehaviour
{
    public GameObject b1, b2, b3, b4, b5;
    public static string nn1, nn2, nn3, nn4, nn5;
    public TMP_Text n1, n2, n3, n4, n5;
    int counttest = 0, count;
    public static int ct = 0;
    StreamReader testsfile;
    StreamWriter writetestsfile;
    List<string> afterfile;

    void Start()
    {
        if(File.Exists("666" + GetName.LoginStd + ".txt"))
        {
            testsfile = new StreamReader("666" + GetName.LoginStd + ".txt");
            counttest = System.IO.File.ReadAllLines("666" + GetName.LoginStd + ".txt").Length;
            ct = counttest;
            Debug.Log(counttest);
            testsfile.ReadLine();
            counttest--;
            ShowTest();
        }
    }
    
    public void Del1()
    {
        string stroka = " ";
        afterfile = new List<string>();
        testsfile = new StreamReader("666" + GetName.LoginStd + ".txt");
        stroka = testsfile.ReadLine();
        afterfile.Add(stroka);
        while (stroka != null) 
        {
            stroka = testsfile.ReadLine();
            if(stroka != n1.text)
            {
                afterfile.Add(stroka);
            }
        }
        testsfile.Close();
        File.Delete("666" + GetName.LoginStd + ".txt");
        writetestsfile = new StreamWriter("666" + GetName.LoginStd + ".txt");
        writetestsfile.WriteLine(afterfile[0]);
        for (int i = 1; i < afterfile.Count; i++) 
        {
            string str = afterfile[i] + "ff";
            if (str[0] == '0' || str[0] == '1' || str[0] == '2' || str[0] == '3' || str[0] == '4' || str[0] == '5' || str[0] == '6' || str[0] == '7' || str[0] == '8' || str[0] == '9')
            {
                writetestsfile.WriteLine(afterfile[i]);
                Debug.Log(afterfile[i]);
            }

        }
        writetestsfile.Close();
        File.Delete(n1.text + ".txt");
        SceneManager.LoadScene("NewAccaunt");
    }
    public void Del2()
    {
        string stroka = " ";
        afterfile = new List<string>();
        testsfile = new StreamReader("666" + GetName.LoginStd + ".txt");
        stroka = testsfile.ReadLine();
        afterfile.Add(stroka);
        while (stroka != null)
        {
            stroka = testsfile.ReadLine();
            if (stroka != n2.text)
            {
                afterfile.Add(stroka);
            }
        }
        testsfile.Close();
        File.Delete("666" + GetName.LoginStd + ".txt");
        writetestsfile = new StreamWriter("666" + GetName.LoginStd + ".txt");
        writetestsfile.WriteLine(afterfile[0]);
        for (int i = 1; i < afterfile.Count; i++)
        {
            string str = afterfile[i] + "ff";
            if (str[0] == '0' || str[0] == '1' || str[0] == '2' || str[0] == '3' || str[0] == '4' || str[0] == '5' || str[0] == '6' || str[0] == '7' || str[0] == '8' || str[0] == '9')
            {
                writetestsfile.WriteLine(afterfile[i]);
                Debug.Log(afterfile[i]);
            }

        }
        writetestsfile.Close();
        File.Delete(n1.text + ".txt");
        SceneManager.LoadScene("NewAccaunt");
    }
    public void Del3()
    {
        string stroka = " ";
        afterfile = new List<string>();
        testsfile = new StreamReader("666" + GetName.LoginStd + ".txt");
        stroka = testsfile.ReadLine();
        afterfile.Add(stroka);
        while (stroka != null)
        {
            stroka = testsfile.ReadLine();
            if (stroka != n3.text)
            {
                afterfile.Add(stroka);
            }
        }
        testsfile.Close();
        File.Delete("666" + GetName.LoginStd + ".txt");
        writetestsfile = new StreamWriter("666" + GetName.LoginStd + ".txt");
        writetestsfile.WriteLine(afterfile[0]);
        for (int i = 1; i < afterfile.Count; i++)
        {
            string str = afterfile[i] + "ff";
            if (str[0] == '0' || str[0] == '1' || str[0] == '2' || str[0] == '3' || str[0] == '4' || str[0] == '5' || str[0] == '6' || str[0] == '7' || str[0] == '8' || str[0] == '9')
            {
                writetestsfile.WriteLine(afterfile[i]);
                Debug.Log(afterfile[i]);
            }

        }
        writetestsfile.Close();
        File.Delete(n1.text + ".txt");
        SceneManager.LoadScene("NewAccaunt");
    }
    public void Del4()
    {
        string stroka = " ";
        afterfile = new List<string>();
        testsfile = new StreamReader("666" + GetName.LoginStd + ".txt");
        stroka = testsfile.ReadLine();
        afterfile.Add(stroka);
        while (stroka != null)
        {
            stroka = testsfile.ReadLine();
            if (stroka != n4.text)
            {
                afterfile.Add(stroka);
            }
        }
        testsfile.Close();
        File.Delete("666" + GetName.LoginStd + ".txt");
        writetestsfile = new StreamWriter("666" + GetName.LoginStd + ".txt");
        writetestsfile.WriteLine(afterfile[0]);
        for (int i = 1; i < afterfile.Count; i++)
        {
            string str = afterfile[i] + "ff";
            if (str[0] == '0' || str[0] == '1' || str[0] == '2' || str[0] == '3' || str[0] == '4' || str[0] == '5' || str[0] == '6' || str[0] == '7' || str[0] == '8' || str[0] == '9')
            {
                writetestsfile.WriteLine(afterfile[i]);
                Debug.Log(afterfile[i]);
            }

        }
        writetestsfile.Close();
        File.Delete(n1.text + ".txt");
        SceneManager.LoadScene("NewAccaunt");
    }
    public void Del5()
    {
        string stroka = " ";
        afterfile = new List<string>();
        testsfile = new StreamReader("666" + GetName.LoginStd + ".txt");
        stroka = testsfile.ReadLine();
        afterfile.Add(stroka);
        while (stroka != null)
        {
            stroka = testsfile.ReadLine();
            if (stroka != n5.text)
            {
                afterfile.Add(stroka);
            }
        }
        testsfile.Close();
        File.Delete("666" + GetName.LoginStd + ".txt");
        writetestsfile = new StreamWriter("666" + GetName.LoginStd + ".txt");
        writetestsfile.WriteLine(afterfile[0]);
        for (int i = 1; i < afterfile.Count; i++)
        {
            string str = afterfile[i] + "ff";
            if (str[0] == '0' || str[0] == '1' || str[0] == '2' || str[0] == '3' || str[0] == '4' || str[0] == '5' || str[0] == '6' || str[0] == '7' || str[0] == '8' || str[0] == '9')
            {
                writetestsfile.WriteLine(afterfile[i]);
                Debug.Log(afterfile[i]);
            }

        }
        writetestsfile.Close();
        File.Delete(n1.text + ".txt");
        SceneManager.LoadScene("NewAccaunt");
    }
    void ShowTest()
    {
        string numer;
        if (counttest == 1)
        {
            numer = testsfile.ReadLine();
            b1.transform.localPosition = new Vector2(-11, 103);
            n1.text = numer;
            b2.transform.localPosition = new Vector2(-11, -2000);
            b3.transform.localPosition = new Vector2(-11, -2000);
            b4.transform.localPosition = new Vector2(-11, -2000);
            b5.transform.localPosition = new Vector2(-11, -2000);
        }
        if (counttest == 2)
        {
            numer = testsfile.ReadLine();
            b1.transform.localPosition = new Vector2(-11, 103);
            n1.text = numer;
            numer = testsfile.ReadLine();
            b2.transform.localPosition = new Vector2(-11, 22);
            n2.text = numer;
            b3.transform.localPosition = new Vector2(-11, -2000);
            b4.transform.localPosition = new Vector2(-11, -2000);
            b5.transform.localPosition = new Vector2(-11, -2000);
        }
        if (counttest == 3)
        {
            numer = testsfile.ReadLine();
            b1.transform.localPosition = new Vector2(-11, 103);
            n1.text = numer;
            numer = testsfile.ReadLine();
            b2.transform.localPosition = new Vector2(-11, 22);
            n2.text = numer;
            numer = testsfile.ReadLine();
            b3.transform.localPosition = new Vector2(-11, -58);
            n3.text = numer;
            b4.transform.localPosition = new Vector2(-11, -2000);
            b5.transform.localPosition = new Vector2(-11, -2000);
        }
        if (counttest == 4)
        {
            numer = testsfile.ReadLine();
            b1.transform.localPosition = new Vector2(-11, 103);
            n1.text = numer;
            numer = testsfile.ReadLine();
            b2.transform.localPosition = new Vector2(-11, 22);
            n2.text = numer;
            numer = testsfile.ReadLine();
            b3.transform.localPosition = new Vector2(-11, -58);
            n3.text = numer;
            numer = testsfile.ReadLine();
            b4.transform.localPosition = new Vector2(-11, -138);
            n4.text = numer;
            b5.transform.localPosition = new Vector2(-11, -2000);
        }
        if (counttest >= 5)
        {
            numer = testsfile.ReadLine();
            b1.transform.localPosition = new Vector2(-11, 103);
            n1.text = numer;
            numer = testsfile.ReadLine();
            b2.transform.localPosition = new Vector2(-11, 22);
            n2.text = numer;
            numer = testsfile.ReadLine();
            b3.transform.localPosition = new Vector2(-11, -58);
            n3.text = numer;
            numer = testsfile.ReadLine();
            b4.transform.localPosition = new Vector2(-11, -138);
            n4.text = numer;
            numer = testsfile.ReadLine();
            b5.transform.localPosition = new Vector2(-11, -214);
            n5.text = numer;
        }
        testsfile.Close();
    }







    private string numertest, wrname;
    private StreamReader usersread;
    public TMP_Text name1, name2, name3;
    private int number_of_name;
    public void rez1()
    {
        SceneManager.LoadScene("Rezalt");
        numertest = n1.text;
    }
    public void rez2()
    {
        SceneManager.LoadScene("Rezalt");
        numertest = n2.text;
    }
    public void rez3()
    {
        SceneManager.LoadScene("Rezalt");
        numertest = n3.text;
    }
    public void rez4()
    {
        SceneManager.LoadScene("Rezalt");
        numertest = n4.text;
    }
    public void rez5()
    {
        SceneManager.LoadScene("Rezalt");
        numertest = n5.text;
    }

}
