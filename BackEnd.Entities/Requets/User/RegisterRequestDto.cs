namespace BackEnd.Entities.Requests.User
{
    /// <summary>
    /// Represents the data required to register a user.
    /// </summary>
    public class RegisterRequestDto
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the user.
        /// </summary>
        public string Phone { get; set; }
    }
}
