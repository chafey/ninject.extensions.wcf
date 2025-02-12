﻿//-------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Ninject Project Contributors">
//   Copyright (c) 2009-2011 Ninject Project Contributors
//   Author: Chris Hafey (chafey@gmail.com)
//
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   you may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------


using System;

namespace WcfRestService
{
	using System.Collections.Generic;

	/// <summary>
	/// An implementation of IRepository
	/// </summary>
	public class Repository : IRepository
	{
		public List<SampleItem> GetCollection()
		{
			return new List<SampleItem>() { new SampleItem() { Id = 1, StringValue = "Hello" } };
		}
	}
}