namespace BackEnd.Entities.Responses
{
    /// <summary>
    /// Represents the response for an operation.
    /// </summary>
    public class ResponseDto
    {
        /// <summary>
        /// Indicates whether the operation was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Contains a message describing the result of the operation.
        /// </summary>
        public string Message { get; set; }
    }
}
