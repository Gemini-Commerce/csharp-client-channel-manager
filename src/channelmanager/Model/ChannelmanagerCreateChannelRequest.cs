/*
 * Channel Manager Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = channelmanager.Client.OpenAPIDateConverter;

namespace channelmanager.Model
{
    /// <summary>
    /// ChannelmanagerCreateChannelRequest
    /// </summary>
    [DataContract(Name = "channelmanagerCreateChannelRequest")]
    public partial class ChannelmanagerCreateChannelRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DefaultLanguage
        /// </summary>
        [DataMember(Name = "defaultLanguage", EmitDefaultValue = false)]
        public ChannelmanagerLanguageCode? DefaultLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ChannelmanagerChannelStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelmanagerCreateChannelRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="code">code.</param>
        /// <param name="image">image.</param>
        /// <param name="name">name.</param>
        /// <param name="defaultLanguage">defaultLanguage.</param>
        /// <param name="settings">settings.</param>
        /// <param name="website">website.</param>
        /// <param name="status">status.</param>
        public ChannelmanagerCreateChannelRequest(string tenantId = default(string), string code = default(string), string image = default(string), string name = default(string), ChannelmanagerLanguageCode? defaultLanguage = default(ChannelmanagerLanguageCode?), ChannelmanagerChannelSettings settings = default(ChannelmanagerChannelSettings), ChannelmanagerChannelTypeWebsite website = default(ChannelmanagerChannelTypeWebsite), ChannelmanagerChannelStatus? status = default(ChannelmanagerChannelStatus?))
        {
            this.TenantId = tenantId;
            this.Code = code;
            this.Image = image;
            this.Name = name;
            this.DefaultLanguage = defaultLanguage;
            this.Settings = settings;
            this.Website = website;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public ChannelmanagerChannelSettings Settings { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public ChannelmanagerChannelTypeWebsite Website { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChannelmanagerCreateChannelRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
