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

using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.Get, "AzureRmLoadBalancerInboundNatRuleConfig"), OutputType(typeof(PSInboundNatRule))]
    [CliCommandAlias("loadbalancer;inboundnat;rule;config;ls")]
    public class GetAzureLoadBalancerInboundNatRuleConfigCommand : NetworkBaseCmdlet
    {
        [Parameter(
            Mandatory = false,
            HelpMessage = "The name of the InboundNatRule")]
        public string Name { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The loadbalancer")]
        public PSLoadBalancer LoadBalancer { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            
            if (!string.IsNullOrEmpty(this.Name))
            {
                var inboundNatRule =
                    this.LoadBalancer.InboundNatRules.First(
                        resource =>
                            string.Equals(resource.Name, this.Name, System.StringComparison.CurrentCultureIgnoreCase));

                WriteObject(inboundNatRule);
            }
            else
            {
                var inboundNatRules = this.LoadBalancer.InboundNatRules;
                WriteObject(inboundNatRules, true);
            }
            
        }
    }
}