using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private List<string> _unusedPrompts;
    private List<string> _unusedQuestions;

    private Random _random = new Random();

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };

        _unusedPrompts = new List<string>(_prompts);
        _unusedQuestions = new List<string>(_questions);
    }

    private string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }

        int index = _random.Next(_unusedPrompts.Count);

        string prompt = _unusedPrompts[index];

        _unusedPrompts.RemoveAt(index);

        return prompt;
    }

    private string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        int index = _random.Next(_unusedQuestions.Count);

        string question = _unusedQuestions[index];

        _unusedQuestions.RemoveAt(index);

        return question;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.WriteLine();
        Console.WriteLine("Press Enter when ready.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now reflect on the following questions:");

        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write($"> {GetRandomQuestion()} ");

            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}