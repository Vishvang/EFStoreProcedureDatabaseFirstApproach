﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFStoreProcedure
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EFMVCDemoEntities : DbContext
    {
        public EFMVCDemoEntities()
            : base("name=EFMVCDemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<EmployeeStore> EmployeeStores { get; set; }
    
        public virtual int DeleteEmployee(Nullable<int> employeeId)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteEmployee", employeeIdParameter);
        }
    
        public virtual int InsertEmployee(string firstName, string lastName, string jobTitle, string address)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var jobTitleParameter = jobTitle != null ?
                new ObjectParameter("JobTitle", jobTitle) :
                new ObjectParameter("JobTitle", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertEmployee", firstNameParameter, lastNameParameter, jobTitleParameter, addressParameter);
        }
    
        public virtual int UpdateEmployee(Nullable<int> employeeId, string firstName, string lastName, string jobTitle, string address)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var jobTitleParameter = jobTitle != null ?
                new ObjectParameter("JobTitle", jobTitle) :
                new ObjectParameter("JobTitle", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateEmployee", employeeIdParameter, firstNameParameter, lastNameParameter, jobTitleParameter, addressParameter);
        }
    
        public virtual ObjectResult<DisplayEmployee_Result> DisplayEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DisplayEmployee_Result>("DisplayEmployee");
        }
    
        public virtual ObjectResult<EmployeeStore> Func_displayEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmployeeStore>("Func_displayEmployee");
        }
    
        public virtual ObjectResult<EmployeeStore> Func_displayEmployee(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmployeeStore>("Func_displayEmployee", mergeOption);
        }
    }
}