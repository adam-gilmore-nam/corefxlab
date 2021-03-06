// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Buffers;

namespace System.Text.Http.Parser
{
    public interface IHttpParser
    {
        bool ParseRequestLine<T>(T handler, in ReadOnlySequence<byte> buffer, out SequencePosition consumed, out SequencePosition examined) where T : IHttpRequestLineHandler;

        bool ParseHeaders<T>(T handler, in ReadOnlySequence<byte> buffer, out SequencePosition consumed, out SequencePosition examined, out int consumedBytes) where T : IHttpHeadersHandler;

        void Reset();
    }
}
