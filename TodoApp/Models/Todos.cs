using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TodoApp.Models
{
    public class Todos
    {

        //-------------- Properties -------------//

        public int Id { get; set; }

        [Required(ErrorMessage = "Namn måste fyllas i")]
        [Display(Name = "Namn")]
        public string? Name { get; set; }

        [Display(Name = "Beskrivning")]
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Startdatum")]
        public DateTime? Date { get; set; }

        [Display(Name = "Prioritet")]
        public string? Priority { get; set; }

        private Random rand = new Random();



        //----------Konstruktor--------------//
        //Id slumpas fram
        public Todos()
        {
            Id = rand.Next(1, 1000);

        }

    }
}
