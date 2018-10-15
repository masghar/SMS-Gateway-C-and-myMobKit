using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingApp.Model
{
    /// <summary>
    /// Contains standard fields for every response.
    /// </summary>
    public abstract class BaseResponse
    {

        /// <summary>
        /// Gets or sets the request method.
        /// </summary>
        /// <value>
        /// The HTTP request method - GET, POST, DELETE, PUT.
        /// </value>
        public string RequestMethod { get; set; }

        /// <summary>
        /// Gets or sets the description. Normally contains the
        /// error message if <seealso cref="IsSuccessful"/> is false.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether request operation is successful.
        /// </summary>
        /// <value>
        /// <c>true</c> if the request is successful; otherwise, <c>false</c>.
        /// </value>
        public bool IsSuccessful { get; set; }
    }
}
