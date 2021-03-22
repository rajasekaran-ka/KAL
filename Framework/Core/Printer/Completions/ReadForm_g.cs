/***********************************************************************************************\
 * (C) KAL ATM Software GmbH, 2021
 * KAL ATM Software GmbH licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
 *
 * This file was created automatically as part of the XFS4IoT Printer interface.
 * ReadForm_g.cs uses automatically generated parts. 
 * created at 3/18/2021 2:05:35 PM
\***********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using XFS4IoT.Completions;

namespace XFS4IoT.Printer.Completions
{
    [DataContract]
    [Completion(Name = "Printer.ReadForm")]
    public sealed class ReadFormCompletion : Completion<ReadFormCompletion.PayloadData>
    {
        public ReadFormCompletion(string RequestId, ReadFormCompletion.PayloadData Payload)
            : base(RequestId, Payload)
        { }

        [DataContract]
        public sealed class PayloadData : MessagePayload
        {
            public enum ErrorCodeEnum
            {
                FormNotFound,
                ReadNotSupported,
                FieldSpecFailure,
                FieldError,
                MediaNotFound,
                MediaInvalid,
                FormInvalid,
                MediaSkewed,
                RetractBinFull,
                ShutterFail,
                MediaJammed,
                InkOut,
                LampInoperative,
                SequenceInvalid,
                MediaSize,
                MediaRejected,
                MsfError,
                NoMSF,
            }

            /// <summary>
            ///An object containing one or more key/value pairs where the key is a field name and the value is the field value. If the field is an index field, the key must be specified as **fieldname[index]** where index specifies the zero-based element of the index field. The field names and values can contain UNICODE if supported by the service.
            /// </summary>
            public class FieldsClass
            {

                public FieldsClass ()
                {
                }


            }


            public PayloadData(CompletionCodeEnum CompletionCode, string ErrorDescription, ErrorCodeEnum? ErrorCode = null, FieldsClass Fields = null)
                : base(CompletionCode, ErrorDescription)
            {
                ErrorDescription.IsNotNullOrWhitespace($"Null or an empty value for {nameof(ErrorDescription)} in received {nameof(ReadFormCompletion.PayloadData)}");

                this.ErrorCode = ErrorCode;
                this.Fields = Fields;
            }

            /// <summary>
            ///Specifies the error code if applicable. The following values are possible:**formNotFound**
            ////  The specified form cannot be found.**readNotSupported**
            ////  The device has no read capability.**fieldSpecFailure**
            ////  The syntax of the *fieldNames* member is invalid.**fieldError**
            ////  An error occurred while processing a field, causing termination of the print request. A  [Printer.FieldErrorEvent](#message-Printer.FieldErrorEvent) event is posted with the details.**mediaNotFound**
            ////  The specified media definition cannot be found.**mediaInvalid**
            ////  The specified media definition is invalid.**formInvalid**
            ////  The specified form definition is invalid.**mediaSkewed**
            ////  The media skew exceeded the limit in the form definition.**retractBinFull**
            ////  The retract bin is full. No more media can be retracted. The current media is still in the device.**shutterFail**
            ////  Open or close of the shutter failed due to manipulation or hardware error.**mediaJammed**
            ////  The media is jammed.**inkOut**
            ////  No stamping possible, stamping ink supply empty.**lampInoperative**
            ////  Imaging lamp is inoperative.**sequenceInvalid**
            ////  Programming error. Invalid command sequence (e.g. *mediaControl* = park and park position is busy).**mediaSize**
            ////  The media entered has an incorrect size.**mediaRejected**
            ////  The media was rejected during the insertion phase. The  [Printer.MediaRejectedEvent](#message-Printer.MediaRejectedEvent) event is posted with the details.  The device is still operational.**msfError**
            ////  The MSF read operation specified by the forms definition could not be completed successfully due to  invalid magnetic stripe data.**noMSF**
            ////  No magnetic stripe found; media may have been inserted or pulled through the wrong way.
            /// </summary>
            [DataMember(Name = "errorCode")] 
            public ErrorCodeEnum? ErrorCode { get; private set; }
            /// <summary>
            ///An object containing one or more key/value pairs where the key is a field name and the value is the field value. If the field is an index field, the key must be specified as **fieldname[index]** where index specifies the zero-based element of the index field. The field names and values can contain UNICODE if supported by the service.
            /// </summary>
            [DataMember(Name = "fields")] 
            public FieldsClass Fields { get; private set; }

        }
    }
}