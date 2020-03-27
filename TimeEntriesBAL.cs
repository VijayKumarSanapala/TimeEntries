using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeEntriesEmployees.Models.DataAccessLayer;
using TimeEntriesEmployees.Models.DisplayClasses;
using TimeEntriesEmployees.Models.Entity;

namespace TimeEntriesEmployees.Models.BusinessAccessLayer
{
    public class TimeEntriesBAL
    {
        TimeEntriesDAL tdal = new TimeEntriesDAL();
        TimeEntriesEntities connection = new TimeEntriesEntities();

        //Getting all the Employee details  
        public List<TimeEntriesViewModelDisplayClasses> GetAll()
        {
           List<TimeEntriesViewModelDisplayClasses> Te = new List<TimeEntriesViewModelDisplayClasses>();
            Te = tdal.GetAll();
            return Te;
                                 
        }

        //Saving the details of the employee
        public bool Save(TimeEntriesViewModelDisplayClasses Te)
        {
            bool res = false;
            try
            {
                if (Te != null)
                {
                    TimeEntriesViewModel tv = new TimeEntriesViewModel();
                    tv.FirstName = Te.FirstName;
                    tv.LastName = Te.LastName;
                    tv.EmailAddress = Te.EmailAddress;
                    tv.Date = Te.Date;
                    tv.Task = Te.Task;
                    tv.HoursWorked = Te.HoursWorked;
                    tv.Comment = Te.Comment;
                    tv.IsActive = true;
                    tv.LastModifiedBy = Te.LastModifiedBy;
                    tv.LastModifiedOn = Te.LastModifiedOn;

                    res = tdal.Save(tv);
                }
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }

        //Delete the Employee based on the id
        public bool Delete(int id)
        {
            bool res = false;

            res = tdal.Delete(id);
            return res;

        }

        //Taking the employee details based on the employeeID
        public TimeEntriesViewModelDisplayClasses GetId(int id)
        {
            TimeEntriesViewModelDisplayClasses tempObject = new TimeEntriesViewModelDisplayClasses();
            TimeEntriesViewModel tem = new TimeEntriesViewModel();
            tem = tdal.GetId(id);
            if (tem != null)
            {
                tempObject.EmployeeID = tem.EmployeeID;
                tempObject.FirstName = tem.FirstName;
                tempObject.LastName = tem.LastName;
                tempObject.EmailAddress = tem.EmailAddress;
                tempObject.Date = tem.Date; ;
                tempObject.Task = tem.Task;
                tempObject.HoursWorked = tem.HoursWorked;
                tempObject.Comment = tem.Comment;
                tempObject.LastModifiedOn = tem.LastModifiedOn;
                tempObject.LastModifiedBy = tem.LastModifiedBy;
            }
            return tempObject;

        }

        //Updating the Employee Details.
        public bool Update(TimeEntriesViewModelDisplayClasses Tm)
        {

            bool res = false;
            try
            {
                if (Tm != null)
                {
                    TimeEntriesViewModel te = new TimeEntriesViewModel();
                    te.EmployeeID = Tm.EmployeeID;
                    te.FirstName = Tm.FirstName;
                    te.LastName = Tm.LastName;
                    te.EmailAddress = Tm.EmailAddress;
                    te.Date = Tm.Date;
                    te.Task = Tm.Task;
                    te.HoursWorked = Tm.HoursWorked;
                    te.Comment = Tm.Comment;
                    te.IsActive = true;
                    te.LastModifiedBy = Tm.LastModifiedBy;
                    te.LastModifiedOn = Tm.LastModifiedOn;

                    res = tdal.Update(te);
                }
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }


    }
}