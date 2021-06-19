using System;
using System.Collections.Generic;
using CyberThink.Model;

namespace CyberThink.ViewModel
{
    public class Quiz_ViewModel
    {
        public List<Question> questions { get;}

        public Quiz_ViewModel()
        {
            questions = new List<Question>();
            this.GenerateQuestionAndAnswers();
        }

        public void GenerateQuestionAndAnswers()
        {
            var QuestionOneAnswers = new List<Answer>();
            QuestionOneAnswers.Add(new Answer() { answer = "Sahil", correct = true });
            QuestionOneAnswers.Add(new Answer() { answer = "Jack", correct = false });
            QuestionOneAnswers.Add(new Answer() { answer = "Will", correct = false });
            QuestionOneAnswers.Add(new Answer() { answer = "Tommy", correct = false });

            var QuestionTwoAnswers = new List<Answer>();
            QuestionTwoAnswers.Add(new Answer() { answer = "19", correct = false });
            QuestionTwoAnswers.Add(new Answer() { answer = "20", correct = false });
            QuestionTwoAnswers.Add(new Answer() { answer = "30", correct = false });
            QuestionTwoAnswers.Add(new Answer() { answer = "21", correct = true });

            var QuestionThreeAnswers = new List<Answer>();
            QuestionThreeAnswers.Add(new Answer() { answer = "Developer", correct = true });
            QuestionThreeAnswers.Add(new Answer() { answer = "Accountant", correct = false });
            QuestionThreeAnswers.Add(new Answer() { answer = "Police Officer", correct = false });
            QuestionThreeAnswers.Add(new Answer() { answer = "Taxman", correct = false });


            questions.Add(new Question() { question = "What is my name ", answers = QuestionOneAnswers });
            questions.Add(new Question() { question = "What is my age", answers = QuestionTwoAnswers });
            questions.Add(new Question() { question = "What is my occupation", answers = QuestionThreeAnswers });


        }

        public bool CheckAnswer(Answer answer)
        {
            if (answer.correct == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
    }
}
