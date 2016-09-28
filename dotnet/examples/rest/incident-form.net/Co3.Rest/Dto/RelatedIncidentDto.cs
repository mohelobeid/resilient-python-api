/*
 * Resilient Systems, Inc. ("Resilient") is willing to license software
 * or access to software to the company or entity that will be using or
 * accessing the software and documentation and that you represent as
 * an employee or authorized agent ("you" or "your") only on the condition
 * that you accept all of the terms of this license agreement.
 *
 * The software and documentation within Resilient's Development Kit are
 * copyrighted by and contain confidential information of Resilient. By
 * accessing and/or using this software and documentation, you agree that
 * while you may make derivative works of them, you:
 *
 * 1)  will not use the software and documentation or any derivative
 *     works for anything but your internal business purposes in
 *     conjunction your licensed used of Resilient's software, nor
 * 2)  provide or disclose the software and documentation or any
 *     derivative works to any third party.
 *
 * THIS SOFTWARE AND DOCUMENTATION IS PROVIDED "AS IS" AND ANY EXPRESS
 * OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL RESILIENT BE LIABLE FOR ANY DIRECT,
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
 * OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Co3.Rest.Dto
{
    /// <summary>
    ///  Contains information about an incident that is related to another incident.  This object is returned in the context of another incident.  For example, if Incident#1 is being retrieved, it might have Incident#2 as a related incident.  In that case, there will be a relatedIncidentDTO object for Incident#2 - depending on the caller, it can return just the data related to Incident#1, or it could return the complete data for Incident#2. Refer to the specific API documentation for details.
    /// </summary>
    public class RelatedIncidentDto
    {

        /// <summary>
        ///  The ID of the related incident.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///  The name of the related incident.  This is a read-only property.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///  The date the incident was created.  This is a read-only property.
        /// </summary>
        [JsonProperty("create_date")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///  The date the incident was closed.  This is a read-only property.
        /// </summary>
        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        ///  The incident status.  This is a read-only property
        /// The possible values with their names are available in
        /// constDTO (incident_statuses property)
        /// .
        /// </summary>
        [JsonProperty("plan_status")]
        public string PlanStatus { get; set; }

        /// <summary>
        ///  The list of artifacts.  Depending on the caller, this list is either the complete list of artifacts for the incident, or only the artifacts that caused this incident to be considered related. This is a read-only property. Consult with the caller API documentation
        /// </summary>
        [JsonProperty("artifacts")]
        public List<IncidentArtifactDto> Artifacts { get; set; }

    }
}
