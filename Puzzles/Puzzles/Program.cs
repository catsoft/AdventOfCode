﻿using System;
using System.Collections.Generic;
using Puzzles.Tasks;

namespace Puzzles
{
	public static class Program
	{
        private static readonly List<TaskData> Tasks = new List<TaskData>()
        {
            new TaskData(new DayOneTaskOne(), "task11","task11"),
            new TaskData(new DayOneTaskTwo(), "task12","task12"),

            new TaskData(new DayTwoTaskOne(), "task21","task21"),
            new TaskData(new DayTwoTaskTwo(), "task22","task22"),

            new TaskData(new DayThreeTaskOne(), "task31","task31"),
            new TaskData(new DayThreeTaskTwo(), "task32","task32"),
        };

        static void Main(string[] args)
        {
            CheckAll();

            var solver = new Solver();

            var task = new DayThreeTaskTwo();
            var taskData = "task32";


            var data = new TaskData(task, taskData);

            Console.WriteLine(solver.TrySolve(data));
            Console.ReadLine();
        }

        private static void TrySolveAll()
        {
            var solver = new Solver();

            Tasks.ForEach(w => Console.WriteLine(solver.TrySolve(w)));

            Console.ReadLine();
        }

        private static void CheckAll()
        {
            var solver = new Solver();

            Tasks.ForEach(w => Console.WriteLine(solver.CheckSolve(w)));

            Console.ReadLine();
        }
    }
}
