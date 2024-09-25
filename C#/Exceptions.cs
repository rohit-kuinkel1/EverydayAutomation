namespace Utility.Exceptions
{
    /// <summary>
    /// Base class for all utility-related exceptions.
    /// </summary>
    internal class UtilityException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityException"/> class.
        /// </summary>
        public UtilityException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityException"/> class with a specified message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public UtilityException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityException"/> class with a specified message and inner exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public UtilityException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Exception thrown when a null argument is passed to a method that requires a non-null argument.
    /// </summary>
    internal class NullException : UtilityException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullException"/> class with a specified parameter name.
        /// </summary>
        /// <param name="message">The error message.</param>
        public NullException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Default constructor for <see cref="NullException"/>
        /// </summary>
        public NullException()
            : base($"Argument cannot be null.")
        {
        }

        /// <summary>
        /// Detailed parameterized constructor with <paramref name="type"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        public NullException(string message, Type type)
            : base(string.Concat(message, $" Type: {type}"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullException"/> class with a specified message and inner exception.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public NullException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Exception thrown when an invalid value is encountered.
    /// </summary>
    internal class InvalidValueException : UtilityException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidValueException"/> class.
        /// </summary>
        public InvalidValueException()
            : base("The provided value is invalid.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidValueException"/> class with a specified message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InvalidValueException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidValueException"/> class with a specified message and inner exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public InvalidValueException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidValueException"/> class with a specified message, inner exception, and invalid value object.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        /// <param name="invalidValue">The invalid value that caused the exception.</param>
        public InvalidValueException(string message, Exception innerException, object invalidValue)
            : base($"{message} Invalid value type: {invalidValue.GetType().Name}", innerException)
        {
        }
    }


    /// <summary>
    /// Exception thrown when a fatal operation cannot continue.
    /// </summary>
    internal class IllegalOperation : UtilityException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IllegalOperation"/> class.
        /// </summary>
        public IllegalOperation()
            : base("Cannot continue because of a fatal operation.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IllegalOperation"/> class with a specified message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public IllegalOperation(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IllegalOperation"/> class with a specified message and inner exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public IllegalOperation(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Exception thrown when deserialization failed.
    /// </summary>
    internal class DeserializationException : UtilityException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeserializationException"/> class.
        /// </summary>
        public DeserializationException()
            : base("Failed to deserialize an object.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeserializationException"/> class with a specified message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public DeserializationException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeserializationException"/> class with a specified message and inner exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public DeserializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Exception thrown when a file format that is not supported is used.
    /// </summary>
    internal class InvalidFileFormat : UtilityException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidFileFormat"/> class.
        /// </summary>
        public InvalidFileFormat()
            : base("Cannot continue because of an invalid file format.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidFileFormat"/> class with a specified message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InvalidFileFormat(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidFileFormat"/> class with a specified message and inner exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public InvalidFileFormat(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
