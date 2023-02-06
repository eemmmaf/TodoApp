﻿using Microsoft.Extensions.Hosting;
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
        public DateTime? CreatedDate { get; }

        [Display(Name = "Startdatum")]
        public DateTime? Date { get; set; }

        [Display(Name = "Prioritet")]
        public string? Priority { get; set; }

        //Lista med val
        public List<SelectListItem>? Priorities { get; }


        private Random rand = new Random();



        //----------Konstruktor--------------//
        //Datum och tid blir den som är nu och id slumpas fram
        public Todos()
        {

            CreatedDate = DateTime.Now;
            Id = rand.Next(1, 1000);




        }

    }
}