using System;

namespace Mongo.Core
{
    /// <summary>
    /// 框架异常
    /// </summary>
    public class MongoModuleException : Exception
    {
        public MongoModuleException() : base()
        {
        }

        public MongoModuleException(string message) : base(message)
        {
        }
    }
}
