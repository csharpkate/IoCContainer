using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IoCContainer.Models;

namespace IoCContainer.Models
{
	public interface ICustomerRepository
	{
		IList<Customer> GetCustomers();
		
	}
	public class CustomerRepository : ICustomerRepository
	{
		
		public Customer Find(int id)
		{
			return FindAll().FirstOrDefault();
		}

		public List<Customer> FindAll()
		{
			var data = new List<Customer>();
			data.Add(new Customer() { Id = 1, Name = "Frodo Baggins" });
			data.Add(new Customer() { Id = 2, Name = "Bilbo Baggins" });
			data.Add(new Customer() { Id = 3, Name = "Peregrin Took" });
			return data;
		}

		IList<Customer> ICustomerRepository.GetCustomers()
		{
			return FindAll();
		}
	}
}