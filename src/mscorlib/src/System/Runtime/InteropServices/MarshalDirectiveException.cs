// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
** Purpose: This exception is thrown when the marshaller encounters a signature
**          that has an invalid MarshalAs CA for a given argument or is not
**          supported.
**
=============================================================================*/


using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    [Serializable]
    public class MarshalDirectiveException : SystemException
    {
        public MarshalDirectiveException()
            : base(Environment.GetResourceString("Arg_MarshalDirectiveException"))
        {
            SetErrorCode(__HResults.COR_E_MARSHALDIRECTIVE);
        }

        public MarshalDirectiveException(String message)
            : base(message)
        {
            SetErrorCode(__HResults.COR_E_MARSHALDIRECTIVE);
        }

        public MarshalDirectiveException(String message, Exception inner)
            : base(message, inner)
        {
            SetErrorCode(__HResults.COR_E_MARSHALDIRECTIVE);
        }

        protected MarshalDirectiveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
