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
    /// ChannelmanagerChannelSettings
    /// </summary>
    [DataContract(Name = "channelmanagerChannelSettings")]
    public partial class ChannelmanagerChannelSettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelmanagerChannelSettings" /> class.
        /// </summary>
        /// <param name="hideOosProducts">hideOosProducts.</param>
        /// <param name="hidePricelessProducts">hidePricelessProducts.</param>
        public ChannelmanagerChannelSettings(bool hideOosProducts = default(bool), bool hidePricelessProducts = default(bool))
        {
            this.HideOosProducts = hideOosProducts;
            this.HidePricelessProducts = hidePricelessProducts;
        }

        /// <summary>
        /// Gets or Sets HideOosProducts
        /// </summary>
        [DataMember(Name = "hideOosProducts", EmitDefaultValue = true)]
        public bool HideOosProducts { get; set; }

        /// <summary>
        /// Gets or Sets HidePricelessProducts
        /// </summary>
        [DataMember(Name = "hidePricelessProducts", EmitDefaultValue = true)]
        public bool HidePricelessProducts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChannelmanagerChannelSettings {\n");
            sb.Append("  HideOosProducts: ").Append(HideOosProducts).Append("\n");
            sb.Append("  HidePricelessProducts: ").Append(HidePricelessProducts).Append("\n");
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
