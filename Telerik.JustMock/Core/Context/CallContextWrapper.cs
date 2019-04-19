﻿/*
 JustMock Lite
 Copyright © 2019 Progress Software Corporation

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

#if !NETCORE
using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace Telerik.JustMock.Core.Context
{
    public class CallContextWrapper : IAsyncContextResolver
    {
        private static readonly string key = Guid.NewGuid().ToString("N");

        public MethodBase GetContext()
        {
            MethodBase methodBase = CallContext.LogicalGetData(key) as MethodBase;
            return methodBase;
        }

        public void CaptureContext()
        {
            MethodBase testMethod = MockingContext.GetTestMethod();
            SetData(testMethod);
        }

        private void SetData(MethodBase methodBase)
        {
            if (methodBase != null)
            {
                CallContext.LogicalSetData(key, methodBase);
            }
        }
    }
}
#endif
