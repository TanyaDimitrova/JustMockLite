/*
 JustMock Lite
 Copyright © 2010-2014 Telerik EAD

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using Telerik.Sitefinity.Web.UI.Fields.Config;

namespace Telerik.Sitefinity.Web.UI.Fields.Contracts
{
	/// <summary>
	/// Defines the mandated members that need to be implemented by every type that
	/// represents a field definition for the controls that implements <see cref="IField"/> interface.
	/// </summary>
	public interface IFieldControlDefinition : IFieldDefinition
	{
		/// <summary>
		/// Gets or sets the programmatic identifier assigned to the field control.
		/// </summary>
		/// <returns>
		/// The programmatic identifier assigned to the field control.
		/// </returns>
		string ID { get; set; }
	}
}
