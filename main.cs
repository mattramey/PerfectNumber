using System;

class PerfectNumber {
  
  public static void Main (string[] args) {// open Main
// declare variables that will be used for the logic of solving a perfect number.
    int number;
    int perfectNumber;
    int sum = 0;
// create a for loop that will itterate a question 4 times to the user getting them to prompt a number.
    for(int i=1; i <= 4; i++){
    Console.WriteLine("Please enter a number betwen 1 and 10,000, let's see if it is a perfect number");
// read the user input, store it in a variable called number and convert the string input into an interger value.
      number = Convert.ToInt32(Console.ReadLine());
      
// reinitialize sum = 0 in order to avoid the sum from the previous iteration from carrying over to the next iteration.    
    sum = 0;
// set perfectNumber to 1 and repeat as long as perfectNumber is < number. increment.If the remainder of number and perfectNumber is 0 that number will be added to the sum variable.
    for(perfectNumber = 1; perfectNumber < number ; purfectNumber++){// open 2nd forloop
      if(number % perfectNumber == 0){ // open nested if
        sum += perfectNumber;
        }// close 1st forloop
      }// close nested if

// if the sum variable is equal to number print the number saying it is a perfect number. if not print that it is not a perfect number.
      if(sum == number){
        Console.WriteLine("The number " + number + " is a perfect number");
        Console.WriteLine();
      } else {
        Console.WriteLine("The number " + number + " is not a perfect number");
        Console.WriteLine();
        }// close else
      }//  close for int i; i<=4; i++
  }// close Main 
}// close PerfectNumber class