/***********************************************************************************************\
 * (C) KAL ATM Software GmbH, 2021
 * KAL ATM Software GmbH licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
 *
 * This file was created automatically as part of the XFS4IoT TextTerminal interface.
 * Write_g.cs uses automatically generated parts. 
 * created at 3/18/2021 2:05:35 PM
\***********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using XFS4IoT.Completions;

namespace XFS4IoT.TextTerminal.Completions
{
    [DataContract]
    [Completion(Name = "TextTerminal.Write")]
    public sealed class WriteCompletion : Completion<WriteCompletion.PayloadData>
    {
        public WriteCompletion(string RequestId, WriteCompletion.PayloadData Payload)
            : base(RequestId, Payload)
        { }

        [DataContract]
        public sealed class PayloadData : MessagePayload
        {
            public enum ErrorCodeEnum
            {
                CharacterSetsData,
            }


            public PayloadData(CompletionCodeEnum CompletionCode, string ErrorDescription, ErrorCodeEnum? ErrorCode = null)
                : base(CompletionCode, ErrorDescription)
            {
                ErrorDescription.IsNotNullOrWhitespace($"Null or an empty value for {nameof(ErrorDescription)} in received {nameof(WriteCompletion.PayloadData)}");

                this.ErrorCode = ErrorCode;
            }

            /// <summary>
            ///Specifies the error code if applicable. The following values are possible:\"characterSetsData\": Character set(s) supported by Service Provider is inconsistent with use of text value.
            /// </summary>
            [DataMember(Name = "errorCode")] 
            public ErrorCodeEnum? ErrorCode { get; private set; }

        }
    }
}
