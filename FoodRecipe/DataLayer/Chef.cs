namespace Luxmis.FoodRecipies.Models
{
    /// <summary>
    /// Implementation of Chef class
    /// </summary>
    public class Chef
    {
        /// <summary>
        /// Gets or sets the Chef ID (employee Id)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Chef rank by popularity. 
        /// Smaller the value, higher the popularity.
        /// </summary>
        public int Rank { get; set; }
    }
}
