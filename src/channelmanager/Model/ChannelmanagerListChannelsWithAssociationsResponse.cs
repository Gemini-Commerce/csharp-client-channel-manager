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
    /// ChannelmanagerListChannelsWithAssociationsResponse
    /// </summary>
    [DataContract(Name = "channelmanagerListChannelsWithAssociationsResponse")]
    public partial class ChannelmanagerListChannelsWithAssociationsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelmanagerListChannelsWithAssociationsResponse" /> class.
        /// </summary>
        /// <param name="channels">channels.</param>
        /// <param name="nextPageToken">nextPageToken.</param>
        public ChannelmanagerListChannelsWithAssociationsResponse(List<ChannelmanagerChannelResponseWithAssociations> channels = default(List<ChannelmanagerChannelResponseWithAssociations>), string nextPageToken = default(string))
        {
            this.Channels = channels;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Gets or Sets Channels
        /// </summary>
        [DataMember(Name = "channels", EmitDefaultValue = false)]
        public List<ChannelmanagerChannelResponseWithAssociations> Channels { get; set; }

        /// <summary>
        /// Gets or Sets NextPageToken
        /// </summary>
        [DataMember(Name = "nextPageToken", EmitDefaultValue = false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChannelmanagerListChannelsWithAssociationsResponse {\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
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