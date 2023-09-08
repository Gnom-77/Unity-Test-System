using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetName : MonoBehaviour
{
    private static string StudenName, StudentPassword, answerTypeTwo, TeacherLogin, TeacherPassword = " ", TestNumber, openanswer, openqwest;
    public static string testname;

    public void TestName(string qw)
    {
        testname = qw;
    }
    public void ReadNameInput(string UserName)
    {
        StudenName = "User " + UserName;
        Debug.Log(StudenName);
    }
    public void ReadOpenQwestInput(string qw)
    {
        openqwest = qw;
        Debug.Log(openqwest);
    }
    public void ReadOpenAnswerInput(string ans)
    {
        openanswer = ans;
        Debug.Log(openanswer);
    }
    public void ReadTestNumber(string TestName)
    {
        TestNumber = TestName;
        Debug.Log(TestName);
    }
    public void ReadLoginInput(string UserLogin)
    {
        TeacherLogin = UserLogin;
        Debug.Log(TeacherLogin);
    }
    public void ReadTeacherPasswordInput(string Password)
    {
        TeacherPassword = Password;
        Debug.Log(TeacherPassword);
    }
    public void ReadPasswordInput(string Password)
    {
        StudentPassword = Password;
        Debug.Log(StudentPassword);
    }
    public void ReadAnswerInput(string answer_two_type)
    {
        if(Answer.GetAnswerTypeTwo == true)
        {
            answerTypeTwo = answer_two_type;
            Debug.Log(answerTypeTwo);
        }
    }

    public static string NameStd
    {
        get { return StudenName; }
    }
    public static string OpenAnsStd
    {
        get { return openanswer; }
        set { openanswer = value; }
    }
    public static string OpenQwsStd
    {
        get { return openqwest; }
    }
    public static string TestStd
    {
        get { return TestNumber; }
    }
    public static string LoginStd
    {
        get { return TeacherLogin; }
    }
    public static string PasswordTeacherStd
    {
        get { return TeacherPassword; }
    }
    public static string PasswordStd
    {
        get { return StudentPassword; }
    }
    public static string AnswerInput
    {
        get { return answerTypeTwo; }
    }

}
