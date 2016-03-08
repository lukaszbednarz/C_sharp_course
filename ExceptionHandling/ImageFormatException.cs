using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandling
{
    [Serializable]
    public class ImageFormatException : Exception
    {
        public ImageFormatException() : base("Invalid Image Format") { }
        public ImageFormatException(string message) : base(message) { }
        public ImageFormatException(string message, Exception inner) : base(message, inner) { }
        public ImageFormatException(Exception inner) : base("Invalid Image Format", inner) { }
        public ImageFormatException(Exception inner, string imagePath) : base("Invalid Image Format", inner) 
        { 
            ImagePath = imagePath; 
        }
        protected ImageFormatException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        public string ImagePath { get; set; }
    }
    
}
