using RoutedLocaliztionExample.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RoutedLocaliztionExample.Models
{
    public class FullViewModel
    {
        public FullViewModel()
        {
            CreationDateTime = DateTime.Now;
        }

        /// <summary>
        /// This will contain localised string value
        /// </summary>
        public string LocalisedString { get; set; }

        /// <summary>
        /// For see difference of cretion time
        /// </summary>
        [Display(Name = "CreationDateTime", ResourceType = typeof(Strings))]
        public DateTime CreationDateTime { get; set; }
    }
}