/***********************************************************************************************\
 * (C) KAL ATM Software GmbH, 2021
 * KAL ATM Software GmbH licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
 *
 * This file was created automatically as part of the XFS4IoT Common interface.
 * DevicePositionEvent_g.cs uses automatically generated parts. 
 * created at 3/18/2021 2:05:35 PM
\***********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using XFS4IoT.Events;

namespace XFS4IoT.Common.Events
{

    [DataContract]
    [Event(Name = "Common.DevicePositionEvent")]
    public sealed class DevicePositionEvent : Event<DevicePositionEvent.PayloadData>
    {

        public DevicePositionEvent(string RequestId, PayloadData Payload)
            : base(RequestId, Payload)
        { }


        [DataContract]
        public sealed class PayloadData : MessagePayloadBase
        {

            public enum PositionEnum
            {
                Inposition,
                Notinposition,
                Posunknown,
            }


            public PayloadData(PositionEnum? Position = null)
                : base()
            {
                this.Position = Position;
            }

            /// <summary>
            ///Position of the device.
            /// </summary>
            [DataMember(Name = "position")] 
            public PositionEnum? Position { get; private set; }
        }

    }
}
