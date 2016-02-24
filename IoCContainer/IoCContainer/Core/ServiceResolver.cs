using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace IoCContainer.Core
{

public class ServiceResolver
	{
		private readonly Dictionary<Type, object> _store;
		private readonly Dictionary<Type, Type> _bindings;

		public ServiceResolver()
		{
			_store = new Dictionary<Type, object>();
			_bindings = new Dictionary<Type, Type>();
		}

		public T Resolve<T>()
		{
			if (!_bindings.ContainsKey(typeof(T)))

				throw new InvalidOperationException($"Requested type {typeof(T).ToString()} has not been registered.");

			var dest = _bindings[typeof(T)];

			if (_store.ContainsKey(dest))
				return (T)_store[dest];

			var obj = (T)Activator.CreateInstance(dest);

			_store.Add(dest, obj);

			return obj;
		}

		public void Register<TFrom, TTo>()
		{
			_bindings.Add(typeof(TFrom), typeof(TTo));
		}

	}
}