using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassRoomApi.Models
{
    public class Room
    {
        //attributes
        public string RoomNumber {get; set;}
        public List<Person> ListOfPeopleInside;
    
        
        ///ctor
        public Room(string roomid)
        {
            this.RoomNumber = roomid;
            this.ListOfPeopleInside = new List<Person>();
            
        }


        public void enterRoom(Person name)
        {
            try
            {    
                if (!this.ListOfPeopleInside.Contains(name))
                {
                    this.ListOfPeopleInside.Add(name);
                    
                    name.realDateTimeEntered = DateTime.Now;
                
                }
            }
            catch (Exception ex) 
            {
                System.Console.WriteLine($"Something went wrong :( Closing Program - {ex.Message}");
            }
            return;
            
        }

        public void leaveRoom(Person name)
        {
           try
           {
                if (this.ListOfPeopleInside.Contains(name))
                {
                    name.DateAndTimeOfExit = DateTime.Now;
                    this.ListOfPeopleInside.Remove(name);
                }
           }
           catch (Exception ex) 
           {
                System.Console.WriteLine($"Something went wrong :( Closing Program - {ex.Message}");
           }
        
            return; 
            
        }

        public bool isRoomEmpty()
        {
            bool empty = false;
            if (this.ListOfPeopleInside.Count == 0)
            {
                empty = true;
            }
            return empty;
        }

         public void nameOfPersonInRoom()
        {
            var personName = from person in this.ListOfPeopleInside
                             where person.Name != null
                             select person;                          
            foreach (var person in personName)
            {
                System.Console.WriteLine(this.RoomNumber);
                System.Console.WriteLine($"Had {person.Name} in it");
                System.Console.WriteLine($"and the real time they entered the room was {person.realDateTimeEntered}");
                System.Console.WriteLine($"they also spent {person.timeSpentinRoom} mins in there");
            }
                   
        }
    }
}