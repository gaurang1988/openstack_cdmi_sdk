using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectStoreSDK
{
    /// <summary>
    /// Executes HTTP Request
    /// </summary>
    public class RequestExecutor : System.Net.WebRequest
    {
        /// <summary>
        /// Executes HTTP Request
        /// </summary>
        /// <param name="request">HTTP Request</param>
        /// <returns>Exceution Result</returns>
        internal static ExecutionResult executeRequest(HTTPRequest request)
        {
            try
            {
                System.Net.WebResponse response = request.GetResponse();
                ExecutionResult executionResult = new ExecutionResult(response);
                return executionResult;
            }
            catch (ExceptionHandler)
            {
                //Console.WriteLine(web.ToString());
                throw;
            }
        }

    }
}
