using System.Collections.Generic;


namespace ClassRoomApi.Models
{
    public class Building
    {
         
        //attributes
        public string buildingName {get; set;}
        public List<Room> RoomsList;
        //ctor
        public Building(string Name)
        {
            this.buildingName = Name;
            this.RoomsList = new List<Room>();
            
        }
        
        //methods
        public void addRoom(Room roomID)
        {
            RoomsList.Add(roomID);
        }

        
    }

}

   