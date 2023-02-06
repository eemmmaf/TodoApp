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

        //Aktivitetens namn
        [Required(ErrorMessage = "Namn måste fyllas i")]
        [Display(Name = "Namn")]
        public string? Name { get; set; }

        //Aktivitetens beskrivning
        [Display(Name = "Beskrivning")]
        public string? Description { get; set; }

        //När den skapades
        public DateTime? CreatedDate { get; set; }

        //Startdatum och tid för aktivitet
        [Display(Name = "Startdatum")]
        public DateTime? Date { get; set; }


        //Prioritet
        [Display(Name = "Prioritet")]
        public string? Priority { get; set; }


        //Random
        private Random rand = new Random();



        //----------Konstruktor--------------//
        public Todos()
        {

            //Id slumpas fram med Random och Next
            Id = rand.Next(1, 1000);

        }

    }
}
