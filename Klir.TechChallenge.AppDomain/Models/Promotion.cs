using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.AppDomain
{
    /// <summary>
    /// This is the rule table for promotion
    /// </summary>
    public class Promotion
    {
        /// <summary>
        /// Promotion Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Divider to apply multiple promotion
        /// </summary>
        public int Divider { get; set; }
        /// <summary>
        /// used in case of amount given
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// used in case of % given
        /// </summary>
        public decimal Percentage { get; set; }
    }
}
