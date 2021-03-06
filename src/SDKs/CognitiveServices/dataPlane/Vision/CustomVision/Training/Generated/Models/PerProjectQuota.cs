// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a set of quotas for a given project
    /// </summary>
    public partial class PerProjectQuota
    {
        /// <summary>
        /// Initializes a new instance of the PerProjectQuota class.
        /// </summary>
        public PerProjectQuota()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PerProjectQuota class.
        /// </summary>
        /// <param name="projectId">Gets the project id of the project this
        /// quota applies to</param>
        /// <param name="iterations">Gets the iteration quota for the
        /// project</param>
        /// <param name="images">Gets the image quota for the project</param>
        /// <param name="tags">Gets the tag quota for the project</param>
        public PerProjectQuota(System.Guid projectId = default(System.Guid), Quota iterations = default(Quota), Quota images = default(Quota), Quota tags = default(Quota))
        {
            ProjectId = projectId;
            Iterations = iterations;
            Images = images;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the project id of the project this quota applies to
        /// </summary>
        [JsonProperty(PropertyName = "ProjectId")]
        public System.Guid ProjectId { get; private set; }

        /// <summary>
        /// Gets the iteration quota for the project
        /// </summary>
        [JsonProperty(PropertyName = "Iterations")]
        public Quota Iterations { get; private set; }

        /// <summary>
        /// Gets the image quota for the project
        /// </summary>
        [JsonProperty(PropertyName = "Images")]
        public Quota Images { get; private set; }

        /// <summary>
        /// Gets the tag quota for the project
        /// </summary>
        [JsonProperty(PropertyName = "Tags")]
        public Quota Tags { get; private set; }

    }
}
