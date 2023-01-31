using System;


namespace TodoApp.Models
{
    public class Todos
    {

        //-------------- Properties -------------//


        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get;}
        public DateTime? Date { get; set; }

        public string? Priority { get; set; }
        



    }
}
