using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace IoCContainer.Core
{
	public class ServiceLocator
	{
		private static ServiceResolver _instance;
		private static object _lock = new object();

		private static ServiceResolver GetInstance()
		{
			lock (_lock)
			{
				return _instance ?? (_instance = new ServiceResolver());
			}
		}

		public static void Register<TFrom, TTo>()
		{
			GetInstance().Register<TFrom, TTo>();
		}

		public static T Resolve<T>()
		{
			return GetInstance().Resolve<T>();
		}


	}
}