namespace Luxmis.FoodRecipies.Models
{
    using System;

    /// <summary>
    /// Implementation of Recipie class.
    /// </summary>
    public class Recipie
    {
        /// <summary>
        /// Gets or sets the Recipie Id assigned into syste.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the recipie friendly name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of recipie.
        /// </summary>
        public RecipieType Type { get; set; }

        /// <summary>
        /// Gets or sets the recipie created by AKA Chef ID
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the recipie category .
        /// </summary>
        public RecipieCategory Category { get; set; }

        /// <summary>
        /// Gets or sets the recipie created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
