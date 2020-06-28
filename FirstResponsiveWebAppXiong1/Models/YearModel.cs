using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppXiong1.Models
{
    /**
     Luke Xiong
     Unit Tests

    I ran out of time to figure out why my method was not working in the Unit Test. I had some issues with my other assignments not
    showing their web pages due to the error messages not displaying information.

    Please consider any points for what I have completed. Thank you!
    **/
    public class YearModel
    {

        [StringLength(20, MinimumLength = 1)]
       [Required(ErrorMessage ="Enter a name.")]
        public string Name { get; set; }

       [Required(ErrorMessage = "Please enter a number.")]
       [Range(1,2019, ErrorMessage = "Enter a year from 1-2019.")]
        public int BirthYear { get; set; }


        public int CurrentYear = 2020;
        //public int Age = 2020 - BirthYear;
        //public double Age;
        //public double CurrentYear = 2020;
        public string AgeThisYear()
        {
            //string message;
            //int Age = 2020 - BirthYear;
            return Name + " " + (CurrentYear - BirthYear) + " years old.";
            
        }

    }
}
