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
using System.Net;

namespace Co3.Rest.Dto
{
    /// <summary>
    ///  Class for transferring information about the currently logged in user.
    /// </summary>
    public class UserSessionDto
    {

        /// <summary>
        /// </summary>
        [JsonProperty("orgs")]
        public List<SessionOrgInfoDto> Orgs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("user_fname")]
        public string UserFname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("user_lname")]
        public string UserLname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("is_saml")]
        public bool IsSaml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("saml_alias")]
        public string SamlAlias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("csrf_token")]
        public string CsrfToken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("session_ip")]
        [JsonConverter(typeof(JsonConverters.IPAddressConverter))]
        public IPAddress SessionIp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("is_ldap")]
        public bool IsLdap { get; set; }

        /// <summary>
        /// </summary>
        [Obsolete]
        public bool Ldap
        {
            get { return IsLdap; }
            set { IsLdap = value; }
        }
    }
}
