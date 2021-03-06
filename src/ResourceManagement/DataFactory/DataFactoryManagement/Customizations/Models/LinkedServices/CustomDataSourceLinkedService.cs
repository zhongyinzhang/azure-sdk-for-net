﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Custom linked service.
    /// </summary>
    [AdfTypeName("CustomDataSource")]
    public sealed class CustomDataSourceLinkedService : LinkedServiceTypeProperties, IGenericTypeProperties
    {
        public IDictionary<string, JToken> ServiceExtraProperties { get; set; }

        public CustomDataSourceLinkedService()
        {   
            this.ServiceExtraProperties = new Dictionary<string, JToken>();
        }

        public CustomDataSourceLinkedService(IDictionary<string, JToken> serviceExtraProperties)
        {
            this.ServiceExtraProperties = serviceExtraProperties;
        }
    }
}
