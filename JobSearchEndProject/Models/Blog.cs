﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EsyJob.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AllDescription { get; set; }
        public DateTime CreateTime { get; set; }
        public string AuthorDesc { get; set; }
        public string AuthorName { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Whatsapp { get; set; }
        public string Instagram { get; set; }
        public string Image { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        //public ICollection<Subcomment> Subcomments { get; set; }


    }
}
