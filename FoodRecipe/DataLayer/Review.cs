namespace Luxmis.FoodRecipies.Models
{
    using System;

    public class Review
    {
        /// <summary>
        /// Gets or sets the Review ID (used for internal purposes)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the review rating.
        /// </summary>
        public ReviewRating Rating { get; set; }

        /// <summary>
        /// Gets or sets the review comments.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the posted by information (user name).
        /// </summary>
        public string PostedBy { get; set; }

        /// <summary>
        /// Gets or sets the review posted date
        /// </summary>
        public DateTime PostedDate { get; set; }
    }
}
