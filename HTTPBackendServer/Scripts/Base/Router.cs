﻿using System.Collections.Generic;

namespace DDUKServer
{
	public class Router
	{
		private Dictionary<string, string> m_Data;

		public Router()
		{
			m_Data = new Dictionary<string, string>();
		}

		public void Add(string path, string pageName)
		{
			m_Data.Add(path, pageName);
		}
	}
}
