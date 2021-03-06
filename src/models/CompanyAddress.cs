using System;
using System.Collections.Generic;
using Newtonsoft.Json;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2017 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Ted Spence
 * @author Zhenya Frolov
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Company Address Information
    /// </summary>
    public class CompanyAddress
    {
        /// <summary>
        /// Address Line1
        /// </summary>
        public String line { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public String city { get; set; }

        /// <summary>
        /// Two character ISO 3166 Region code for this company's primary business location.
        /// </summary>
        public String region { get; set; }

        /// <summary>
        /// Two character ISO 3166 Country code for this company's primary business location.
        /// </summary>
        public String country { get; set; }

        /// <summary>
        /// Postal Code
        /// </summary>
        public String postalCode { get; set; }


        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }
    }
}
