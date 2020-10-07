using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{


    public class Assessment
    {
        // the access priviledged to this class is public
        //programs  (outside user) can use this class
        // it is not static, therfore the outside user will have to create an instance of this class if they wish to use it

        //Priovate Data Members
        // A private data memeber can not be touched by the outside user

        //properies are the interface to the outside world
        //properties that are referenced by th outside world need to be exposed, that is made public
        //properties have the syntax accesstype datatyp propertyname {coding block}
        //auto implemented properties do not need a private data member data is stored internally by the system using the requested datatype
        //access to data stored using this implementation MUST be via the property name

        //Fully implemented properties requires a private data member of the same datatype as the property 
        //data is stored in the private data member any coding within the class itself can access the private data member
        //best practice is to always use the property and NOT directly access the private data member
        // reason : the property likely has special coding to validate or manage the data which you do not want to by-pass
        //Comment is a nullable field, it is a string, we wish to avoid storing an empty string. We either have NO data (null) 
        //or we have a character string with at least one real character

        //get is used when the property is on the " right side" of an assignment statement
        
        //set is used when the data is trying to be placed within the instance ("left side" of an assignment statement

        // since  properties do NOT have a parameter  list AND are associated with a single piec of data, the data within the property is accessed
        // a single piece of data, the data within the property is accessed using the key word --> value

        private string _Comment;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string AssessmentName { get; set; }

        public double Mark { get; set; }

        public string Comment
        {
            get { return _Comment; }
            set { _Comment = string.IsNullOrEmpty(value) ? null : value; }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Assessment myInstance = new Assessment();


            myInstance.FirstName = "Jeff";
            myInstance.LastName = "Paltridge";
            myInstance.AssessmentName = "Core Portfolio 5";
            myInstance.Mark = 99.9;

            Console.WriteLine($"First Name: {myInstance.FirstName} Last name: {myInstance.LastName} Assessment : {myInstance.AssessmentName} Mark: {myInstance.Mark} Comments: <{myInstance.Comment}>");


            Assessment(string firsname, string lastname, string assessmentname, double mark, string comment)
            {
                FirstName = firsname;
                LastName = lastname;
                AssessmentName = assessmentname;
                Mark = mark;
                Comment = comment;
                
            }


        }


        /*
         * if your class has no constructor the system will create an instance and initial all your data storage area (data member or auto properties)
         * to their basic system defaults
         * 
         * WARNING !!!!!!!!!!!!
         * If you code one constructor, then you are responsible for any and all constructors the system will not do anything on your behalf.
         * 
         * constructors
         * constructors are used to intial ith beginning state of an instance
         * 
         * Default Constructor
         * 
         * characteristics : no parameters
         * coding blod may or may not assign literal values to your data storage
         * 
         */


        /* public Assessment()
         {
             /* opptionally assign a literal to a data storage area
              * notice: good coding practice is to use Properties and not directly the data member
              * 
              * Mark = 0.0;
              * comment = "no comment";
         }*/



    }
}
