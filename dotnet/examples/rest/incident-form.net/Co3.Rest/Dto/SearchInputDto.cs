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
    ///  Holds the details of a search query.  Used in the POST /rest/search endpoint.
    /// </summary>
    public class SearchInputDto
    {

        /// <summary>
        ///  The search query.
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        ///  The number of results per page (anything more than 20 will be set to 20).
        /// </summary>
        [JsonProperty("rpp")]
        public int Rpp { get; set; }

        /// <summary>
        ///  The org to restrict search to (null for all)
        /// </summary>
        [JsonProperty("org_id")]
        public int OrgId { get; set; }

        /// <summary>
        ///  The types of object to restrict the search to (Incident, Task, Comment)
        /// </summary>
        [JsonProperty("types")]
        public List<string> Types { get; set; }

        /// <summary>
        ///  The ID of the user to restrict results to
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        ///  The statuses of the incident (open/closed).
        /// </summary>
        [JsonProperty("incident_statuses")]
        public List<string> IncidentStatuses { get; set; }

        /// <summary>
        ///  The statuses of the task (open/closed).
        /// </summary>
        [JsonProperty("task_statuses")]
        public List<string> TaskStatuses { get; set; }

    }
}
