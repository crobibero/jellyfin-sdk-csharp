// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Jellyfin.Sdk.Generated.Audio.Item.MainM3u8 {
    /// <summary>
    /// Builds and executes requests for operations under \Audio\{itemId}\main.m3u8
    /// </summary>
    public class MainM3u8RequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="MainM3u8RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MainM3u8RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Audio/{itemId}/main.m3u8{?allowAudioStreamCopy*,allowVideoStreamCopy*,audioBitRate*,audioChannels*,audioCodec*,audioSampleRate*,audioStreamIndex*,breakOnNonKeyFrames*,context*,copyTimestamps*,cpuCoreLimit*,deInterlace*,deviceId*,deviceProfileId*,enableAutoStreamCopy*,enableMpegtsM2TsMode*,framerate*,height*,level*,liveStreamId*,maxAudioBitDepth*,maxAudioChannels*,maxFramerate*,maxRefFrames*,maxStreamingBitrate*,maxVideoBitDepth*,mediaSourceId*,minSegments*,params*,playSessionId*,profile*,requireAvc*,requireNonAnamorphic*,segmentContainer*,segmentLength*,startTimeTicks*,static*,streamOptions*,subtitleCodec*,subtitleMethod*,subtitleStreamIndex*,tag*,transcodeReasons*,transcodingMaxAudioChannels*,videoBitRate*,videoCodec*,videoStreamIndex*,width*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MainM3u8RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MainM3u8RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Audio/{itemId}/main.m3u8{?allowAudioStreamCopy*,allowVideoStreamCopy*,audioBitRate*,audioChannels*,audioCodec*,audioSampleRate*,audioStreamIndex*,breakOnNonKeyFrames*,context*,copyTimestamps*,cpuCoreLimit*,deInterlace*,deviceId*,deviceProfileId*,enableAutoStreamCopy*,enableMpegtsM2TsMode*,framerate*,height*,level*,liveStreamId*,maxAudioBitDepth*,maxAudioChannels*,maxFramerate*,maxRefFrames*,maxStreamingBitrate*,maxVideoBitDepth*,mediaSourceId*,minSegments*,params*,playSessionId*,profile*,requireAvc*,requireNonAnamorphic*,segmentContainer*,segmentLength*,startTimeTicks*,static*,streamOptions*,subtitleCodec*,subtitleMethod*,subtitleStreamIndex*,tag*,transcodeReasons*,transcodingMaxAudioChannels*,videoBitRate*,videoCodec*,videoStreamIndex*,width*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets an audio stream using HTTP live streaming.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<MainM3u8RequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<MainM3u8RequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets an audio stream using HTTP live streaming.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MainM3u8RequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MainM3u8RequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/x-mpegURL");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="MainM3u8RequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MainM3u8RequestBuilder WithUrl(string rawUrl)
        {
            return new MainM3u8RequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets an audio stream using HTTP live streaming.
        /// </summary>
        public class MainM3u8RequestBuilderGetQueryParameters 
        {
            /// <summary>Whether or not to allow copying of the audio stream url.</summary>
            [QueryParameter("allowAudioStreamCopy")]
            public bool? AllowAudioStreamCopy { get; set; }
            /// <summary>Whether or not to allow copying of the video stream url.</summary>
            [QueryParameter("allowVideoStreamCopy")]
            public bool? AllowVideoStreamCopy { get; set; }
            /// <summary>Optional. Specify an audio bitrate to encode to, e.g. 128000. If omitted this will be left to encoder defaults.</summary>
            [QueryParameter("audioBitRate")]
            public int? AudioBitRate { get; set; }
            /// <summary>Optional. Specify a specific number of audio channels to encode to, e.g. 2.</summary>
            [QueryParameter("audioChannels")]
            public int? AudioChannels { get; set; }
            /// <summary>Optional. Specify a audio codec to encode to, e.g. mp3. If omitted the server will auto-select using the url&apos;s extension. Options: aac, mp3, vorbis, wma.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("audioCodec")]
            public string? AudioCodec { get; set; }
#nullable restore
#else
            [QueryParameter("audioCodec")]
            public string AudioCodec { get; set; }
#endif
            /// <summary>Optional. Specify a specific audio sample rate, e.g. 44100.</summary>
            [QueryParameter("audioSampleRate")]
            public int? AudioSampleRate { get; set; }
            /// <summary>Optional. The index of the audio stream to use. If omitted the first audio stream will be used.</summary>
            [QueryParameter("audioStreamIndex")]
            public int? AudioStreamIndex { get; set; }
            /// <summary>Optional. Whether to break on non key frames.</summary>
            [QueryParameter("breakOnNonKeyFrames")]
            public bool? BreakOnNonKeyFrames { get; set; }
            /// <summary>Optional. The MediaBrowser.Model.Dlna.EncodingContext.</summary>
            [QueryParameter("context")]
            public GetContextQueryParameterType? Context { get; set; }
            /// <summary>Whether or not to copy timestamps when transcoding with an offset. Defaults to false.</summary>
            [QueryParameter("copyTimestamps")]
            public bool? CopyTimestamps { get; set; }
            /// <summary>Optional. The limit of how many cpu cores to use.</summary>
            [QueryParameter("cpuCoreLimit")]
            public int? CpuCoreLimit { get; set; }
            /// <summary>Optional. Whether to deinterlace the video.</summary>
            [QueryParameter("deInterlace")]
            public bool? DeInterlace { get; set; }
            /// <summary>The device id of the client requesting. Used to stop encoding processes when needed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("deviceId")]
            public string? DeviceId { get; set; }
#nullable restore
#else
            [QueryParameter("deviceId")]
            public string DeviceId { get; set; }
#endif
            /// <summary>Optional. The dlna device profile id to utilize.</summary>
            [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("deviceProfileId")]
            public string? DeviceProfileId { get; set; }
#nullable restore
#else
            [QueryParameter("deviceProfileId")]
            public string DeviceProfileId { get; set; }
#endif
            /// <summary>Whether or not to allow automatic stream copy if requested values match the original source. Defaults to true.</summary>
            [QueryParameter("enableAutoStreamCopy")]
            public bool? EnableAutoStreamCopy { get; set; }
            /// <summary>Optional. Whether to enable the MpegtsM2Ts mode.</summary>
            [QueryParameter("enableMpegtsM2TsMode")]
            public bool? EnableMpegtsM2TsMode { get; set; }
            /// <summary>Optional. A specific video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements.</summary>
            [QueryParameter("framerate")]
            public float? Framerate { get; set; }
            /// <summary>Optional. The fixed vertical resolution of the encoded video.</summary>
            [QueryParameter("height")]
            public int? Height { get; set; }
            /// <summary>Optional. Specify a level for the encoder profile (varies by encoder), e.g. 3, 3.1.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("level")]
            public string? Level { get; set; }
#nullable restore
#else
            [QueryParameter("level")]
            public string Level { get; set; }
#endif
            /// <summary>The live stream id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("liveStreamId")]
            public string? LiveStreamId { get; set; }
#nullable restore
#else
            [QueryParameter("liveStreamId")]
            public string LiveStreamId { get; set; }
#endif
            /// <summary>Optional. The maximum audio bit depth.</summary>
            [QueryParameter("maxAudioBitDepth")]
            public int? MaxAudioBitDepth { get; set; }
            /// <summary>Optional. Specify a maximum number of audio channels to encode to, e.g. 2.</summary>
            [QueryParameter("maxAudioChannels")]
            public int? MaxAudioChannels { get; set; }
            /// <summary>Optional. A specific maximum video framerate to encode to, e.g. 23.976. Generally this should be omitted unless the device has specific requirements.</summary>
            [QueryParameter("maxFramerate")]
            public float? MaxFramerate { get; set; }
            /// <summary>Optional.</summary>
            [QueryParameter("maxRefFrames")]
            public int? MaxRefFrames { get; set; }
            /// <summary>Optional. The maximum streaming bitrate.</summary>
            [QueryParameter("maxStreamingBitrate")]
            public int? MaxStreamingBitrate { get; set; }
            /// <summary>Optional. The maximum video bit depth.</summary>
            [QueryParameter("maxVideoBitDepth")]
            public int? MaxVideoBitDepth { get; set; }
            /// <summary>The media version id, if playing an alternate version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("mediaSourceId")]
            public string? MediaSourceId { get; set; }
#nullable restore
#else
            [QueryParameter("mediaSourceId")]
            public string MediaSourceId { get; set; }
#endif
            /// <summary>The minimum number of segments.</summary>
            [QueryParameter("minSegments")]
            public int? MinSegments { get; set; }
            /// <summary>The streaming parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("params")]
            public string? Params { get; set; }
#nullable restore
#else
            [QueryParameter("params")]
            public string Params { get; set; }
#endif
            /// <summary>The play session id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("playSessionId")]
            public string? PlaySessionId { get; set; }
#nullable restore
#else
            [QueryParameter("playSessionId")]
            public string PlaySessionId { get; set; }
#endif
            /// <summary>Optional. Specify a specific an encoder profile (varies by encoder), e.g. main, baseline, high.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("profile")]
            public string? Profile { get; set; }
#nullable restore
#else
            [QueryParameter("profile")]
            public string Profile { get; set; }
#endif
            /// <summary>Optional. Whether to require avc.</summary>
            [QueryParameter("requireAvc")]
            public bool? RequireAvc { get; set; }
            /// <summary>Optional. Whether to require a non anamorphic stream.</summary>
            [QueryParameter("requireNonAnamorphic")]
            public bool? RequireNonAnamorphic { get; set; }
            /// <summary>The segment container.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("segmentContainer")]
            public string? SegmentContainer { get; set; }
#nullable restore
#else
            [QueryParameter("segmentContainer")]
            public string SegmentContainer { get; set; }
#endif
            /// <summary>The segment length.</summary>
            [QueryParameter("segmentLength")]
            public int? SegmentLength { get; set; }
            /// <summary>Optional. Specify a starting offset, in ticks. 1 tick = 10000 ms.</summary>
            [QueryParameter("startTimeTicks")]
            public long? StartTimeTicks { get; set; }
            /// <summary>Optional. If true, the original file will be streamed statically without any encoding. Use either no url extension or the original file extension. true/false.</summary>
            [QueryParameter("static")]
            public bool? Static { get; set; }
            /// <summary>Optional. The streaming options.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("streamOptions")]
            public string? StreamOptions { get; set; }
#nullable restore
#else
            [QueryParameter("streamOptions")]
            public string StreamOptions { get; set; }
#endif
            /// <summary>Optional. Specify a subtitle codec to encode to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("subtitleCodec")]
            public string? SubtitleCodec { get; set; }
#nullable restore
#else
            [QueryParameter("subtitleCodec")]
            public string SubtitleCodec { get; set; }
#endif
            /// <summary>Optional. Specify the subtitle delivery method.</summary>
            [QueryParameter("subtitleMethod")]
            public GetSubtitleMethodQueryParameterType? SubtitleMethod { get; set; }
            /// <summary>Optional. The index of the subtitle stream to use. If omitted no subtitles will be used.</summary>
            [QueryParameter("subtitleStreamIndex")]
            public int? SubtitleStreamIndex { get; set; }
            /// <summary>The tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tag")]
            public string? Tag { get; set; }
#nullable restore
#else
            [QueryParameter("tag")]
            public string Tag { get; set; }
#endif
            /// <summary>Optional. The transcoding reason.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("transcodeReasons")]
            public string? TranscodeReasons { get; set; }
#nullable restore
#else
            [QueryParameter("transcodeReasons")]
            public string TranscodeReasons { get; set; }
#endif
            /// <summary>Optional. The maximum number of audio channels to transcode.</summary>
            [QueryParameter("transcodingMaxAudioChannels")]
            public int? TranscodingMaxAudioChannels { get; set; }
            /// <summary>Optional. Specify a video bitrate to encode to, e.g. 500000. If omitted this will be left to encoder defaults.</summary>
            [QueryParameter("videoBitRate")]
            public int? VideoBitRate { get; set; }
            /// <summary>Optional. Specify a video codec to encode to, e.g. h264. If omitted the server will auto-select using the url&apos;s extension. Options: h265, h264, mpeg4, theora, vpx, wmv.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("videoCodec")]
            public string? VideoCodec { get; set; }
#nullable restore
#else
            [QueryParameter("videoCodec")]
            public string VideoCodec { get; set; }
#endif
            /// <summary>Optional. The index of the video stream to use. If omitted the first video stream will be used.</summary>
            [QueryParameter("videoStreamIndex")]
            public int? VideoStreamIndex { get; set; }
            /// <summary>Optional. The fixed horizontal resolution of the encoded video.</summary>
            [QueryParameter("width")]
            public int? Width { get; set; }
        }
    }
}
