using Assignment3;

//Question1.Main();
//Question2.Main();


Ball redBall = new Ball(10, new Color(255, 0, 0));
redBall.Throw();
redBall.Throw();
redBall.Pop();
redBall.Throw(); // Should not increment throw count as the ball is popped.

Console.WriteLine($"Red ball thrown {redBall.GetThrowCount()} times.");

Student bob = new Student("Bob", new DateTime(2000, 1, 1));
Instructor jane = new Instructor("Jane", new DateTime(1980, 1, 1), new DateTime(2005, 1, 1));
bob.CalculateAge();
jane.CalculateSalary();
