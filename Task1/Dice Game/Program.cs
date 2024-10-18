using System;

Console.WriteLine("Role the Dice");

Random num1 = new Random();
Random num2 = new Random();

while(true){
    int my_num,com_num;
    my_num=num1.Next(1,7);
    com_num=num2.Next(1,7);
    
    Console.WriteLine("my number is {0}, computer's number is {1}",my_num,com_num);
    if(my_num == com_num)
    {
        Console.WriteLine("Draw! Reroll.");
        continue;
    }
    else
    {
        if(my_num>com_num)
        {
            Console.WriteLine("I Win!");
            break;
        }
        else
        {
            Console.WriteLine("Computer Wins");
            break;
        }
    }
}

