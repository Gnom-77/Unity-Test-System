using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public GameObject b1, b2, b3, b4, b5, b6, b0;
    public GameObject[] buttonchange;
    public TMP_Text[] answers_array;
    public TMP_Text a1, a2, a3, a4, a5, a6, que, chet;
    private string questions, answer, str, trueAunswerInFile;
    private string[] questionsFileForRead;
    private List<string> rightAnswers = new List<string>();
    private List<string> userAnswers = new List<string>();
    TextReader questionsFile;
    static StreamWriter fileForAnswer, UsersFile;
    static int number_of_questions, number_of_responses;
    private static bool answerTypeTwo = false;
    private static int googAnswer, finalAnswerInt, RightAnswerInt;
    public static int rrr;
    public TMP_InputField type_two_answer;

    //public Text a1, a2, a3, a4, que;
    public static bool GetAnswerTypeTwo
    {
        get { return answerTypeTwo; }
    }
    public static int GetFinalAnswer
    {
        get { return finalAnswerInt; }
    }
    public static int GetRightAnswer
    {
        get { return RightAnswerInt; }
    }
    void Start()
    {
        rrr = 0;
        questionsFile = new StreamReader(GetName.PasswordStd + ".txt");
        questionsFileForRead = readFile(questionsFile);
        number_of_questions = File.ReadAllLines(GetName.PasswordStd + ".txt").Length;
        RightAnswerInt = number_of_questions;
        writeQuestions();
        chet.text = rrr + " из " + RightAnswerInt;
    }
    private void FixedUpdate()
    {
        chet.text = rrr + " из " + RightAnswerInt;
    }

    public static int Number_Of_Responses
    {
        set { number_of_responses = value; }
        get { return number_of_responses; }
    }
    public static void OpenFileForWrite()
    {
        fileForAnswer = new StreamWriter(GetName.NameStd + ".txt");

        List<string> list = new List<string>();
        string str;
        if (File.Exists("Users_" + GetName.PasswordStd + ".txt"))
        {
            StreamReader read = new StreamReader("Users_" + GetName.PasswordStd + ".txt");
            str = read.ReadLine();
            while (str != null)
            {
                list.Add(str);
                str = read.ReadLine();
            }
            read.Close();
        }

        UsersFile = new StreamWriter("Users_" + GetName.PasswordStd + ".txt");
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log("AAAAA-->" + list[i]);
            UsersFile.WriteLine(list[i]);
        }
        UsersFile.WriteLine(GetName.NameStd);
        UsersFile.Close();
    }
    public void NextQuestions()
    {
        if (GetAnswerTypeTwo == true)
        {
            fileForAnswer.WriteLine(questions);
            fileForAnswer.Write(GetName.AnswerInput + "*!_!*");
            fileForAnswer.WriteLine("");
            if (number_of_questions > 1)
            {
                questionsFileForRead = readFile(questionsFile);
                if (GetName.AnswerInput == trueAunswerInFile)
                {
                    finalAnswerInt += 1;
                }
                writeQuestions();
                number_of_questions -= 1;
            }
            else
            {
                fileForAnswer.WriteLine("");
                fileForAnswer.WriteLine("!___!" + Convert.ToString(GetFinalAnswer) + " из " + Convert.ToString(GetRightAnswer));
                questionsFile.Close();
                fileForAnswer.Close();
                SceneChanger.ChangeSceneForTotalStudent();
            }
                
        }
        else
        {
            if (number_of_questions > 1)
            {
                fileForAnswer.WriteLine(questions);
                for (int i = 0; i < buttonchange.Length; i++)
                {
                    if (buttonchange[i].GetComponent<Image>().color == Color.yellow)
                    {
                        buttonchange[i].GetComponent<Image>().color = Color.white;
                        Debug.Log(answers_array[i].text);
                        userAnswers.Add(Convert.ToString(answers_array[i].text)); 
                        fileForAnswer.Write(Convert.ToString(answers_array[i].text) + "*!_!*");
                    }
                }
                if (AnswerCount() == true)
                    finalAnswerInt += 1;
                fileForAnswer.WriteLine("");
                questionsFileForRead = readFile(questionsFile);
                writeQuestions();
                number_of_questions -= 1;
            }
            else
            {
                fileForAnswer.WriteLine(questions);
                for (int i = 0; i < buttonchange.Length; i++)
                {
                    if (buttonchange[i].GetComponent<Image>().color == Color.yellow)
                    {
                        buttonchange[i].GetComponent<Image>().color = Color.white;
                        Debug.Log(answers_array[i].text);
                        userAnswers.Add(answers_array[i].text);
                        fileForAnswer.Write(Convert.ToString(answers_array[i].text) + "*!_!*");
                    }
                }
                if (AnswerCount() == true)
                    finalAnswerInt += 1;
                fileForAnswer.WriteLine("");
                fileForAnswer.WriteLine("!___!" + Convert.ToString(GetFinalAnswer) + " из " + Convert.ToString(GetRightAnswer));
                questionsFile.Close();
                fileForAnswer.Close();
                SceneChanger.ChangeSceneForTotalStudent();
            }
        }

    }
    private string[] readFile(TextReader questionsFile)
    {  
        str = questionsFile.ReadLine();
        questionsFileForRead = str.Split("*!_!*");
        return questionsFileForRead;
    }
    private void writeAnswe(string answer)
    {
        rrr += 1;
        Vector2 unnecessary_answer = new Vector2(0, -2000);
        string[] allAnswer = answer.Split("-&");
        rightAnswers = trueAunswerInFile.Split("-&").ToList();
        if (allAnswer.Length == 2)
        {
            b0.transform.localPosition = unnecessary_answer;
            b3.transform.localPosition = unnecessary_answer;
            b4.transform.localPosition = unnecessary_answer;
            b5.transform.localPosition = unnecessary_answer;
            b6.transform.localPosition = unnecessary_answer;
            b1.transform.localPosition = new Vector2(0, 50);
            b2.transform.localPosition = new Vector2(0, -29);
            a1.text = allAnswer[0];
            a2.text = allAnswer[1];
        }
        if (allAnswer.Length == 3)
        {
            b0.transform.localPosition = unnecessary_answer;
            b4.transform.localPosition = unnecessary_answer;
            b5.transform.localPosition = unnecessary_answer;
            b6.transform.localPosition = unnecessary_answer;
            b1.transform.localPosition = new Vector2(0, 50);
            b2.transform.localPosition = new Vector2(0, -29);
            b3.transform.localPosition = new Vector2(0, -113);
            a1.text = allAnswer[0];
            a2.text = allAnswer[1];
            a3.text = allAnswer[2];
        }
        if (allAnswer.Length == 4)
        {
            b0.transform.localPosition = unnecessary_answer;
            b5.transform.localPosition = unnecessary_answer;
            b6.transform.localPosition = unnecessary_answer;
            b1.transform.localPosition = new Vector2(0, 50);
            b2.transform.localPosition = new Vector2(0, -29);
            b3.transform.localPosition = new Vector2(0, -113);
            b4.transform.localPosition = new Vector2(0, -194);
            a1.text = allAnswer[0];
            a2.text = allAnswer[1];
            a3.text = allAnswer[2];
            a4.text = allAnswer[3];

        }
        if (allAnswer.Length == 5)
        {
            b0.transform.localPosition = unnecessary_answer;
            b6.transform.localPosition = unnecessary_answer;
            b1.transform.localPosition = new Vector2(-184, 51);
            b2.transform.localPosition = new Vector2(-184, -29);
            b3.transform.localPosition = new Vector2(-184, -113);
            b4.transform.localPosition = new Vector2(182, 51);
            b5.transform.localPosition = new Vector2(182, -29);
            a1.text = allAnswer[0];
            a2.text = allAnswer[1];
            a3.text = allAnswer[2];
            a4.text = allAnswer[3];
            a5.text = allAnswer[4];
        }
        if (allAnswer.Length == 6)
        {
            b0.transform.localPosition = unnecessary_answer;
            b1.transform.localPosition = new Vector2(-184, 51);
            b2.transform.localPosition = new Vector2(-184, -29);
            b3.transform.localPosition = new Vector2(-184, -113);
            b4.transform.localPosition = new Vector2(182, 51);
            b5.transform.localPosition = new Vector2(182, -29);
            b6.transform.localPosition = new Vector2(182, -113);
            a1.text = allAnswer[0];
            a2.text = allAnswer[1];
            a3.text = allAnswer[2];
            a4.text = allAnswer[3];
            a5.text = allAnswer[4];
            a6.text = allAnswer[5];
        }
    }
    private void writeAnsweTypeTwo()
    {
        type_two_answer.text = "";
        rrr += 1;
        Vector2 unnecessary_answer = new Vector2(0, -2000);
        b1.transform.localPosition = unnecessary_answer;
        b2.transform.localPosition = unnecessary_answer;
        b3.transform.localPosition = unnecessary_answer;
        b4.transform.localPosition = unnecessary_answer;
        b5.transform.localPosition = unnecessary_answer;
        b6.transform.localPosition = unnecessary_answer;
        b0.transform.localPosition = new Vector2(-2, -53);
    }

    private void writeQuestions()
    {
        if (questionsFileForRead[0] == "1")
        {
            answerTypeTwo = false; // тип вопроса
            questions = questionsFileForRead[1]; // вопрос
            answer = questionsFileForRead[2]; // варианты ответов
            trueAunswerInFile = questionsFileForRead[4]; // правильные ответы
            que.text = questions; 
            number_of_responses = Convert.ToInt16(questionsFileForRead[3]); // кол-во правильных ответов
            writeAnswe(answer);
        }
        if (questionsFileForRead[0] == "2")
        {
            trueAunswerInFile = questionsFileForRead[2];
            Debug.Log("Мы это читаем?? " + questionsFileForRead[2]);
            answerTypeTwo = true;
            questions = questionsFileForRead[1];
            que.text = questions;
            writeAnsweTypeTwo();
        }
    }
    private bool AnswerCount()
    {
        char[] charsToTrim = { '*', ' ', '\'' };
        bool isEqual = true;
        //for (int i = 0; i < rightAnswers.Count; i++)
        //{
        //    rightAnswers[i] = rightAnswers[i].Trim(charsToTrim);
        //}
        for (int i = 0; i < userAnswers.Count; i++)
        {
            userAnswers[i] = userAnswers[i].Trim(charsToTrim);
        }
        if (rightAnswers.Count == userAnswers.Count)
        {
            rightAnswers.Sort();
            userAnswers.Sort();
            for (int i = 0; i < rightAnswers.Count; i++)
            {
                if (rightAnswers[i] != userAnswers[i]) 
                {
                    isEqual = false;
                }
            }
        }
        else
        {
            isEqual = false;
        }
        Debug.Log(isEqual);
        rightAnswers.Clear();
        userAnswers.Clear();
        return isEqual;
    }
}
