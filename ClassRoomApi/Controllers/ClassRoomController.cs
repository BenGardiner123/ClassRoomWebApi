using ClassRoomApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ClassRoomApi.Controllers
{
   
    [ApiController]
    [Route("[controller]")]
    public class ClassRoomController: ControllerBase
    {
        public List<Room> RoomList = new List<Room>();
        public List<Person> PersonList = new List<Person>();

        Building b1 = new Building("The hotel");
        Room r1 = new Room("TD224");
        Room r2 = new Room("AGSE111");
        Person p1 = new Person("Huber Matos");
        Person p2 = new Person("Fidel Castro");
        

        public ClassRoomController()
        {
            RoomList.Add(r1);
            RoomList.Add(r2);
        }

         [HttpGet("GetRooms")]
         public List<Room> getallRooms()
        {
            return RoomList;
        }
        
        
        
        [HttpPost("EnterRoom")]
        public void EnterRoom()
        {
            r1.enterRoom(p1);
            r2.enterRoom(p2);
        
        }

        [HttpGet("Test")]
         public List<Person> Test()
        {
            return r1.ListOfPeopleInside.ToList();
        }

        
        [HttpGet("PeopleInRoom")]
         public List<Person> PeopleInRoom(Room id)
         {
            
            var personName = from person in id.ListOfPeopleInside
                             where person.Name != null
                             select person;                          
            foreach (var person in personName)
            {
                PersonList.Add(person);

            }
            return PersonList;
         }
    }
    
}