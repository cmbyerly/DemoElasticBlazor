namespace DemoElasticBlazor.Shared
{
    public class ItemDto
    {
        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        /// <value>
        /// The name of the item.
        /// </value>
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets the item description.
        /// </summary>
        /// <value>
        /// The item description.
        /// </value>
        public string ItemDescription { get; set; }

        /// <summary>
        /// Gets or sets the item quanitity.
        /// </summary>
        /// <value>
        /// The item quanitity.
        /// </value>
        public int ItemQuanitity { get; set; }

        /// <summary>
        /// Gets or sets the item price.
        /// </summary>
        /// <value>
        /// The item price.
        /// </value>
        public double ItemPrice { get; set; }
    }
}
