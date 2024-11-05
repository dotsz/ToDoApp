using System;

Task task = new Task().Initialize("Test", false);

Console.WriteLine($"Task is: {task.Name} + Done? {task.isDone.ToString()}");
