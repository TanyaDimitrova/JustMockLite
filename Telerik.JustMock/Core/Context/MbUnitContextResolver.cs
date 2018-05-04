/*
 JustMock Lite
 Copyright © 2010-2015 Telerik EAD

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

using System;

namespace Telerik.JustMock.Core.Context
{
	internal class MbUnitContextResolver : HierarchicalTestFrameworkContextResolver
	{
		private const string MbUnitAssertionFailedName = "Gallio.Framework.Assertions.AssertionException, gallio";

		public MbUnitContextResolver()
			: base(MbUnitAssertionFailedName)
		{
			SetupStandardHierarchicalTestStructure(
				new[] { "Gallio.Framework.Pattern.TestMethodPatternAttribute, gallio" },
				new[] { "MbUnit.Framework.SetUpAttribute, mbunit", "MbUnit.Framework.TearDownAttribute, mbunit" },
				new[] { "MbUnit.Framework.FixtureSetUpAttribute, mbunit", "MbUnit.Framework.FixtureTearDownAttribute, mbunit" },
				null,
				FixtureConstuctorSemantics.InstanceConstructorCalledOncePerFixture);
		}

		public static bool IsAvailable
		{
			get { return FindType(MbUnitAssertionFailedName, false) != null; }
		}
	}
}
