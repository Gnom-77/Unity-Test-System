using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class CreatNewAccaunt : MonoBehaviour
{
    public TMP_InputField inputfieldname, questionsfield;
    public TMP_InputField[] hideanswer;
    public GameObject NumerTest, crt, add, open, hide, buttonopen, buttonhide, blockwithqwest, b1, b2, b3, b4, b5, b6, nex;
    public GameObject[] buttonsanswer;
    private TextReader questionsFile;
    public TMP_Text shou_count_qwest;
    private int count_qwest;
    static StreamWriter teacherFileWrite, fileForAnswer;
    private string[] questionsFileForRead;
    private string str;
    static int number_of_questions = 0;
    private bool isopen = false;
    static public int hideteacheranswer;
    public TMP_InputField name_for_test;
    public void CreateTest()
    {
        if(ShowAllTest.ct < 5)
        {
            SceneChanger.ChangeSceneForCreateTest();
        }
        //teacherFile = new StreamWriter("666" + GetName.LoginStd + ".txt");
        
    }
    public void Rezalt()
    {

    }
    public void FirstAnswer()
    {
        if(chekNumber(GetName.TestStd) == true && GetName.TestStd.Length < 5)
        {
            nex.transform.position = new Vector2(10000, 10000);
            count_qwest = 0;
            shou_count_qwest.text = count_qwest + "/30";
            NumerTest.transform.localPosition = new Vector2(0, -2000);
            crt.transform.localPosition = new Vector2(332.38f, -212.21f);
            add.transform.localPosition = new Vector2(138, -212.21f);
            buttonopen.transform.localPosition = new Vector2(-196.1f, 105.47f);
            buttonhide.transform.localPosition = new Vector2(196.1f, 105.47f);
            StreamWriter file = new StreamWriter(GetName.TestStd + ".txt");
            
            Destroy(NumerTest);
            StreamReader teacherFile = new StreamReader("666" + GetName.LoginStd + ".txt");
            string teacherString = teacherFile.ReadToEnd() + GetName.TestStd;
            
            teacherFile.Close();
            teacherFileWrite = new StreamWriter("666" + GetName.LoginStd + ".txt");
            teacherFileWrite.WriteLine(teacherString);
            teacherFileWrite.Close();
            file.Close();
            //File.AppendAllText("666" + GetName.LoginStd + ".txt", GetName.TestStd);
            OpenFileForWrite();
            //fileForAnswer = new StreamWriter(GetName.TestStd + ".txt");
            //Answer.OpenFileForWrite();
        }
        else
        {
            if(chekNumber(GetName.TestStd) == false)
            {
                name_for_test.text = "Название теста состоит из цифр";
            }
            else 
            {
                name_for_test.text = "Колличество цифр должно быть < 5";
            }
            
        }
    }
    public void openqwest()
    {
        blockwithqwest.transform.localPosition = new Vector2(0, 191);
        open.transform.localPosition = new Vector2(70.72551f, -22.934f);
        b1.transform.localPosition = new Vector2(-333, -2000);
        b2.transform.localPosition = new Vector2(-333, -2000);
        b3.transform.localPosition = new Vector2(-333, -2000);
        b4.transform.localPosition = new Vector2(-333, -2000);
        b5.transform.localPosition = new Vector2(-333, -2000);
        b6.transform.localPosition = new Vector2(-333, -2000);
        isopen = true;
    }
    public void hideqwest()
    {
        blockwithqwest.transform.localPosition = new Vector2(0, 191);
        open.transform.localPosition = new Vector2(70.72551f, -2000);
        b1.transform.localPosition = new Vector2(-333, 33);
        b2.transform.localPosition = new Vector2(-333, -11);
        b3.transform.localPosition = new Vector2(-333, -56);
        b4.transform.localPosition = new Vector2(-333, -101);
        b5.transform.localPosition = new Vector2(-333, -148);
        b6.transform.localPosition = new Vector2(-333, -193);
        isopen = false;
    }

    public static void OpenFileForWrite()
    {
        fileForAnswer = new StreamWriter(GetName.TestStd + ".txt");
    }
    public void addqwest()
    {
        if (questionsfield.text != null && questionsfield.text != string.Empty)
        {
            if (count_qwest < 30)
            {
                if (isopen == true)
                {
                    if (GetName.OpenAnsStd == null || GetName.OpenAnsStd == string.Empty)
                    {
                        inputfieldname.text = "Введите ответ";
                    }
                    else
                    {
                        fileForAnswer.WriteLine("2*!_!*" + GetName.OpenQwsStd + "*!_!*" + GetName.OpenAnsStd);
                        inputfieldname.text = "";
                        open.transform.localPosition = new Vector2(70.72551f, -2000f);
                        questionsfield.text = "";
                        number_of_questions++;
                        count_qwest++;
                        shou_count_qwest.text = count_qwest + "/30";
                        GetName.OpenAnsStd = null;
                    }
                }
                else
                {
                    int chekanswer = 0, rightchekanswer = 0;
                    List<string> answer = new List<string>();
                    List<string> rightanswer = new List<string>();
                    for (int i = 0; i < hideanswer.Length; i++)
                    {
                        if (hideanswer[i].text != string.Empty && hideanswer[i].text != null && hideanswer[i].text != "")
                        {
                            chekanswer++;
                            answer.Add(hideanswer[i].text);
                            if (buttonsanswer[i].GetComponent<Image>().color == Color.green)
                            {
                                rightchekanswer++;
                                rightanswer.Add(hideanswer[i].text);
                            }
                        }
                    }
                    if (chekanswer > 1 && rightchekanswer > 0)
                    {
                        fileForAnswer.Write("1*!_!*" + GetName.OpenQwsStd + "*!_!*");
                        for (int i = 0; i < answer.Count - 1; i++)
                        {
                            fileForAnswer.Write(answer[i] + "-&");
                        }
                        fileForAnswer.Write(answer[answer.Count - 1] + "*!_!*");
                        if (rightchekanswer == 1)
                        {
                            fileForAnswer.Write("1*!_!*");
                        }
                        else
                        {
                            fileForAnswer.Write("6*!_!*");
                        }
                        for (int i = 0; i < rightanswer.Count - 1; i++)
                        {
                            fileForAnswer.Write(rightanswer[i] + "-&");
                        }
                        fileForAnswer.Write(rightanswer[rightanswer.Count - 1]);
                        fileForAnswer.WriteLine("");
                        count_qwest++;
                        shou_count_qwest.text = count_qwest + "/30";
                        number_of_questions++;
                        questionsfield.text = "";
                        for (int i = 0; i < buttonsanswer.Length; i++)
                        {
                            if (buttonsanswer[i].GetComponent<Image>().color == Color.green)
                            {
                                buttonsanswer[i].GetComponent<Image>().color = Color.white;
                            }
                        }
                    }
                    for (int i = 0; i < hideanswer.Length; i++)
                    {
                        hideanswer[i].text = "";
                    }
                }
            }
        }
        else
        {
            questionsfield.text = "Введите вопрос!!!";
        }



    }
    public void createtest()
    {
        if(number_of_questions > 0)
        {
            fileForAnswer.Close();
            SceneManager.LoadScene("NewAccaunt");
        }

    }
    private bool chekNumber(string str) 
    {
        bool next = false;
        string numer = "1234567890";
        for (int i = 0; i < str.Length; i++)
        {
            next = false;
            for (int j = 0; j < numer.Length; j++)
            {
                if (GetName.TestStd[i] == numer[j])
                {
                    next = true;
                }
            }
            if (next == false)
            {
                break;
            }
        }
        return next;
    }
}
