using System;
using System.Runtime.Serialization;

namespace Rock.Rest.v2.Models
{
    /// <summary>
    /// DTO used by the ControlsController for the GroupPickerOptions endpoint.
    /// </summary>
    [DataContract]
    public class GroupPickerOptionDto
    {
        /// <summary>
        /// The unique identifier of the group.
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }

        /// <summary>
        /// The display name of the group.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Whether this group is active.
        /// </summary>
        [DataMember]
        public bool IsActive { get; set; }
    }
}