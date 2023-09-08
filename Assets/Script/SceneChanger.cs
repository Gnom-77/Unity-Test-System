using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public TMP_Text namestd, passwordstd;
    static StreamWriter teacherFile;
    public TMP_InputField IF_name, IF_test;
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ChangeSceneForTestStudent(string sceneName)
    {
        if ((ChekName(GetName.NameStd)) && (File.Exists(GetName.PasswordStd + ".txt")) && GetName.NameStd.Length < 100)
        {
            //FileInfo UserFile = new FileInfo(GetName.NameStd + ".txt");
            //UserFile.Create();
            Answer.OpenFileForWrite();
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            if (ChekName(GetName.NameStd) == false)
                IF_name.text = "�������� ���";
            if (File.Exists(GetName.PasswordStd + ".txt") == false)
            {
                IF_test.text = "����� �� ����������";
            }
            if (GetName.NameStd.Length >= 100)
            {
                IF_name.text = "��� ������� �������";
            }
        }
        //else
        //{
        //    if (ChekName(GetName.NameStd) == false)
        //    {
        //        namestd.text = "�������� ��� ������������";
        //    }
        //    if (File.Exists(GetName.PasswordStd + ".txt") == false)
        //    {
        //        passwordstd.text = "�������� ����� �����";
        //    }
        //}
    }
    public void ChangeSceneForNewTeacher(string sceneName)
    {
        if (ChekLogin(GetName.LoginStd) && GetName.PasswordTeacherStd[0] != ' ' && GetName.PasswordTeacherStd != null && GetName.PasswordTeacherStd != string.Empty)
        {
            Debug.Log("������-->" + GetName.PasswordTeacherStd[0]);
            teacherFile = new StreamWriter("666" + GetName.LoginStd + ".txt");
            teacherFile.WriteLine(GetName.PasswordTeacherStd);
            teacherFile.Close();
            //Answer.OpenFileForWrite();
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            if (ChekLogin(GetName.LoginStd) == false)
            {
                IF_name.text = "�������� �����";
            }
            if (GetName.PasswordTeacherStd == null || GetName.PasswordTeacherStd == string.Empty)
            {
                IF_test.text = "���������� ������";
            }
            else
            {
                if (GetName.PasswordTeacherStd[0] == ' ')
                {
                    IF_test.text = "���������� ������";
                }
            }
            

        }
    }
    public void ChangeSceneForOldTeacher()
    {
        StreamReader fileoldteacher;
        string password;
        if (File.Exists("666" + GetName.LoginStd + ".txt"))
        {
            fileoldteacher = new StreamReader("666" + GetName.LoginStd + ".txt");
            password = fileoldteacher.ReadLine();
            Debug.Log(GetName.PasswordTeacherStd + " And " + password);
            if (password == GetName.PasswordTeacherStd) 
            {
                SceneManager.LoadScene("NewAccaunt");
            }
            else
            {
                IF_test.text = "�������� ������";
            }
        }
        else
        {
            IF_name.text = "�������� �� ����������";
        }
    }
    static public void ChangeSceneForTotalStudent()
    {
        SceneManager.LoadScene("TotalStudent");
    }
    static public void ChangeSceneForCreateTest()
    {
        SceneManager.LoadScene("CreateTest");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public bool ChekName(string nameStudent)
    {
        nameStudent += " ";
        bool checkName = false;
        string s = "qwertyuiopasdfghjklzxcvbnm��������������������������������";
        char[] CheckSymbolInName = s.ToCharArray();
        for (int i = 0; i < nameStudent.Length - 1; i++)
        {
            checkName = false;
            for (int j = 0; j < s.Length; j++)
            {
                if (Char.ToLower(nameStudent[i]) == s[j])
                {
                    checkName = true;
                }
            }
            if (nameStudent[i] == ' ' && Char.IsUpper(nameStudent[i + 1]) == true)
            {
                checkName = true;
                Debug.Log(nameStudent[i] + " �� ��� �� ���������");
            }
            if (checkName == false) 
                break;
        }
        if (Char.IsUpper(nameStudent[0]) == false)
        {
            checkName = false;
            Debug.Log(nameStudent[0] + " ������ ������ ���");
        }
        return checkName;
    }
    public bool ChekLogin(string LoginTeacher)
    {
        bool chLogin = false;
        Debug.Log(LoginTeacher);
        string s = "qwertyuiopasdfghjklzxcvbnm��������������������������������_-.1234567890";
        for (int i = 0; i < LoginTeacher.Length; i++)
        {
            
            chLogin = false;
            for (int j = 0; j < s.Length; j++)
            {
                if (Char.ToLower(LoginTeacher[i]) == s[j])
                {
                    chLogin = true;
                }
            }
            if(chLogin == false)
                break;
        }
        return chLogin;
    }
}
