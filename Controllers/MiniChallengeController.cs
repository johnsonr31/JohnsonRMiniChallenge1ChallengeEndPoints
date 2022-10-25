// Richard Johnson
// 10-25-22
// 
// Peer Review: 

using Microsoft.AspNetCore.Mvc;

namespace JohnsonRMiniChallenge1ChallengeEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallengeController : ControllerBase
{
    [HttpGet]
    [Route("Hello")]

    public string SayHello()
    {
        string name = "Alex";
        return $"Hello {name}.";
    }

    [HttpGet]
    [Route("Adding")]

    public string AddingNumbers()
    {
        int num1 = 3;
        int num2 = 5;
        int sum = num1 + num2;
        return $"{num1} + {num2} = {sum}";
    }

    [HttpGet]
    [Route("Asking")]

    public string AskingQuestions()
    {
        string name = "Jesse";
        string wakeTime = "6:10";
        return "So, your name is " + name + " and you woke up at " + wakeTime + " this morning?";
    }

    [HttpGet]
    [Route("Greater")]

    public string GreaterThanLessThan()
    {
        int num1 = 5;
        int num2 = 7;
        return $"{num2} is greater than {num1}.";
    }   

    [HttpGet]
    [Route("Mad")]

    public string MadLib()
    {
        string name = "John";
        string animal = "dog";
        string color = "green";
        string noun = "box";
        string location = "park";
        string verb = "talked";
        string noun2 = "friends";
        return $"{name} lived in a {color} {noun}. One day, {name} met a talking {animal} who wanted to go for a walk through the {location}. \nThey both walked and {verb}, and ended up becoming good {noun2} with each other. \nTHE END";
    }   

    [HttpGet]
    [Route("Odd")]

    public string OddEven()
    {
        int num = 103;
        return $"{num} is an odd number.";
    }   

    [HttpGet]
    [Route("Reverse")]

    public string ReverseIt()
    {
        int num = 1234567;
        int reverseNum = 7654321;
        return $"{num} in reverse is {reverseNum}";
    }   

    [HttpGet]
    [Route("Eight")]

    public string MagicEightBall()
    {
        string eightBallAnswer = "Don't count on it";
        Random random = new Random();
        int randomNum = random.Next(1,8);
        switch(randomNum)
        {
            case 1: eightBallAnswer = "Don't count on it"; break;

            case 2: eightBallAnswer = "Yes"; break;
            
            case 3: eightBallAnswer = "No"; break;
            
            case 4: eightBallAnswer = "Signs point to no"; break;
            
            case 5: eightBallAnswer = "Reply hazy, try again"; break;
            
            case 6: eightBallAnswer = "My sources say yes"; break;
            
            case 7: eightBallAnswer = "Better not tell you now"; break;
            
            case 8: eightBallAnswer = "As I see it, yes"; break;
        }
        return "As the eight ball, and recieve an answer:\n \n" + eightBallAnswer;
    }   

    [HttpGet]
    [Route("Restaurant")]

    public string RestaurantPicker()
    {
        Random random = new Random();
        int random1 = random.Next(0,2);
        string category = "";
        string fastFood1;

        switch(random1)
        {
            case 0: category = "Fast Food"; break;
            case 1: category = "Chinese Takeout"; break;
            case 2: category = "Italian"; break;
        }
        return $"Pick a Restaurant category: \nFast Food, Chinese Takeout, Italian.\nYour choice is {category} \nYou will be able to pick a restaurant category and recieve a randomly selected restaurant from a category";
    }   


}
