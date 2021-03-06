﻿using System.Web.Mvc;
using IoCContainer.Controllers;
using IoCContainer.Models;
using IoCContainer.Core;
using NUnit.Framework;


namespace IoCContainer.Tests.Controllers
{
	[TestFixture]
	public class HomeControllerTest
	{
		
		[Test]
		public void Index()
		{
			//Arrange
			HomeController controller = new HomeController();

			ServiceLocator.Register<ICustomerRepository, CustomerRepository>();
			//Act
			ViewResult result = controller.Index() as ViewResult;
			//Assert
			Assert.IsNotNull(result);
		}

		[Test]
		public void About()
		{
			//Arrange
		 HomeController controller = new HomeController();

			//Act
		 ViewResult result = controller.About() as ViewResult;

		//	Assert
		Assert.IsNotNull(result);
		}

		[Test]
		public void Contact()
		{
			//Arrange
		 HomeController controller = new HomeController();

			//Act
		 ViewResult result = controller.Contact() as ViewResult;

		//	Assert
      Assert.IsNotNull(result);
		}
	}
}
