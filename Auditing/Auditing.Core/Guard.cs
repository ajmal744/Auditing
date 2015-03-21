using System;

namespace Auditing.Core
{
    /// <summary>
    /// Represents the class to check null validation patterns.
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// Checks a string argument to ensure it isn't null or empty
        /// </summary>
        /// <param name="argumentValue">The argument value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <exception cref="ArgumentNullException">Throw if the argument is null</exception>
        /// <exception cref="ArgumentException">Throw if the argument is empty</exception>
        public static void ArgumentNotNullOrEmpty(string argumentValue, string argumentName)
        {
            if (argumentValue == null)
            {
                throw new ArgumentNullException(argumentName);
            }

            if (string.IsNullOrEmpty(argumentValue))
            {
                throw new ArgumentException("Empty string", argumentName);
            }
        }

        /// <summary>
        /// Checks an argument to ensure it isn't null
        /// </summary>
        /// <param name="argumentValue">The argument value to check.</param>
        /// <param name="argumentName">The name of the argument.</param>
        public static void ArgumentNotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }
    }
}
