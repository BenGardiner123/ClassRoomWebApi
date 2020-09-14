using System;



namespace ClassRoomApi.Models
{
    public class Person
    {
        //attributes
        public string Name {get; set;}
        public DateTime realDateTimeEntered {get; set;}

        public DateTime DateAndTimeEntered {get; set;}
        public DateTime DateAndTimeOfExit {get; set;}
        public TimeSpan timeSpentinRoom {get; set;}

        //ctor
        public Person(string name)
        {
         Name = name;
         this.DateAndTimeEntered = DateTime.Now;   
         
        }

        public void addName(string userInput){
            
            if (this.Name == null)
            {
                this.Name = userInput;
            }
            else
            {
                System.Console.WriteLine("This person already has a name");
            }
            
        }
        public void setDate(string userInput)
        {
            DateTime userDate = new DateTime();
            userDate = DateTime.Parse(userInput);
            userDate = this.DateAndTimeEntered;
   
        }

        public void stayHowLong(string userInput)
        {   
            TimeSpan Time = new TimeSpan();
            Time = TimeSpan.Parse(userInput);
            
            this.timeSpentinRoom = Time;
        }
        

    }

}




