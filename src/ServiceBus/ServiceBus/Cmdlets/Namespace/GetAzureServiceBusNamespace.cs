﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.ServiceBus.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;


namespace Microsoft.Azure.Commands.ServiceBus.Commands.Namespace
{
    /// <summary>
    /// 'Get-AzServiceBusNamespace' Cmdlet gives the details of a / List of Servicebus Namespace(s)
    /// <para> If Namespace name provided, a single Namespace detials will be returned</para>
    /// <para> If Namespace name not provided, list of Namespace will be returned</para>
    /// </summary>
    [GenericBreakingChange("Output type of the cmdlet would change to `Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbNamespace`. This cmdlet would henceforth be alias cmdlet with Get-AzServiceBusNamespaceV2.", deprecateByVersion: DeprecateByVersion, changeInEfectByDate: ChangeInEffectByDate)]
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ServiceBusNamespace"), OutputType(typeof(PSNamespaceAttributes))]
    public class GetAzureRmServiceBusNamespace : AzureServiceBusCmdletBase
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, Position = 0, HelpMessage = "The name of the resource group")]
        [ResourceGroupCompleter]
        [Alias("ResourceGroup")]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, Position = 1, HelpMessage = "Namespace Name")]
        [Alias(AliasNamespaceName)]
        public string Name { get; set; }

        /// <summary>
        /// Gets a Namespace from the service.
        /// </summary>
        /// <returns>A single Namespace</returns>
        public override void ExecuteCmdlet()
        {
            try
            {
                if (!string.IsNullOrEmpty(ResourceGroupName) && !string.IsNullOrEmpty(Name))
                {
                    // Get a namespace
                    PSNamespaceAttributes attributes = Client.GetNamespace(ResourceGroupName, Name);
                    WriteObject(attributes);
                }
                else if (!string.IsNullOrEmpty(ResourceGroupName) && string.IsNullOrEmpty(Name))
                {
                    // List all namespaces in given resource group 
                    IEnumerable<PSNamespaceAttributes> namespaceList = Client.ListNamespaces(ResourceGroupName);
                    WriteObject(namespaceList.ToList(), true);
                }
                else
                {
                    // List all namespaces in the given subscription
                    IEnumerable<PSNamespaceAttributes> namespaceList = Client.ListAllNamespaces();
                    WriteObject(namespaceList.ToList(), true);
                }
            }
            catch (Management.ServiceBus.Models.ErrorResponseException ex)
            {
                WriteError(ServiceBusClient.WriteErrorforBadrequest(ex));
            }
        }
    }
}
