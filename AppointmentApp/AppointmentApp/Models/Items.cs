using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace AppointmentApp.Models
{
    [Table("AppointmentApp")]
    public class Items
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string Name { get; set; }
        public string TShirtSize { get; set; }
        public string TShirtColor { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }




    }
}    



