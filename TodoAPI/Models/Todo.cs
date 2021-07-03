using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }

        public Todo ConvertDTO(TodoDTO todoDTO)
        {
            return new Todo { Name = todoDTO.Name, Description = todoDTO.Description, Time = todoDTO.Time };
        }
    }
}
