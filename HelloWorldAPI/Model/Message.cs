using System;
namespace HelloWorldAPI.Model
{
    public class Message
    {
        string Value { get; set; }
        //Below are some possible future elements of the class that 
        //are not useful for this demo
        DateTime DateCreated { get; set; }
        int CreatedByID { get; set; }

        public Message(string val)
        {
            Value = val;
        }
        public override string ToString()
        {
            return Value;
        }
        ///TO-DO: Gets Message object by id from database
        public static Message Get(int id)
        {
            //To Do
            return new Message("To Do");
        }
        ///TO-DO: Creates a new Message object in the database
        public int Create(Message data)
        {
            //To Do
            return 0;
        }
        ///TO-DO: update Message object in the database
        public void Update(Message data)
        {
            //To Do
        }
        ///TO-DO: delete Message object in the database
        public void Delete(Message data)
        {
            //To Do
        }
    }
}
