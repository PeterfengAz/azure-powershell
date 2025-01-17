// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>An IP Configuration of the private endpoint.</summary>
    public partial class PrivateEndpointIPConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationInternal
    {

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>
        /// The ID of a group obtained from the remote resource that this private endpoint should connect to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationPropertiesInternal)Property).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationPropertiesInternal)Property).GroupId = value ?? null; }

        /// <summary>
        /// The member name of a group obtained from the remote resource that this private endpoint should connect to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string MemberName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationPropertiesInternal)Property).MemberName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationPropertiesInternal)Property).MemberName = value ?? null; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.PrivateEndpointIPConfigurationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the resource that is unique within a resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>A private ip address obtained from the private endpoint's subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationPropertiesInternal)Property).PrivateIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationPropertiesInternal)Property).PrivateIPAddress = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationProperties _property;

        /// <summary>Properties of private endpoint IP configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.PrivateEndpointIPConfigurationProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="PrivateEndpointIPConfiguration" /> instance.</summary>
        public PrivateEndpointIPConfiguration()
        {

        }
    }
    /// An IP Configuration of the private endpoint.
    public partial interface IPrivateEndpointIPConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>
        /// The ID of a group obtained from the remote resource that this private endpoint should connect to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of a group obtained from the remote resource that this private endpoint should connect to.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>
        /// The member name of a group obtained from the remote resource that this private endpoint should connect to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The member name of a group obtained from the remote resource that this private endpoint should connect to.",
        SerializedName = @"memberName",
        PossibleTypes = new [] { typeof(string) })]
        string MemberName { get; set; }
        /// <summary>The name of the resource that is unique within a resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource that is unique within a resource group.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>A private ip address obtained from the private endpoint's subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A private ip address obtained from the private endpoint's subnet.",
        SerializedName = @"privateIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateIPAddress { get; set; }
        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// An IP Configuration of the private endpoint.
    internal partial interface IPrivateEndpointIPConfigurationInternal

    {
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string Etag { get; set; }
        /// <summary>
        /// The ID of a group obtained from the remote resource that this private endpoint should connect to.
        /// </summary>
        string GroupId { get; set; }
        /// <summary>
        /// The member name of a group obtained from the remote resource that this private endpoint should connect to.
        /// </summary>
        string MemberName { get; set; }
        /// <summary>The name of the resource that is unique within a resource group.</summary>
        string Name { get; set; }
        /// <summary>A private ip address obtained from the private endpoint's subnet.</summary>
        string PrivateIPAddress { get; set; }
        /// <summary>Properties of private endpoint IP configurations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfigurationProperties Property { get; set; }
        /// <summary>The resource type.</summary>
        string Type { get; set; }

    }
}