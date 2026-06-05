using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectionActivity()
        : base (     
            "Reflection", 
            "This activity will help your reflect on times in your life when you have shown strenght and resilience.")
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different", 
            "What did you learn about yourself?"
        };
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions.");
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