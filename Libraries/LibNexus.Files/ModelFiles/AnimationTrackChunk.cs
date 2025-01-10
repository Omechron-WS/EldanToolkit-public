using LibNexus.Core.Extensions;
using System.IO;

namespace EldanToolkit.Libraries.LibNexus.Files.ModelFiles
{
	public class AnimationTrackChunk
	{
		public ulong FrameCount { get; set; }
		public ulong TimestampOffset { get; set; }
		public ulong ValueOffset { get; set; }

		public AnimationTrackChunk(Stream stream)
		{
			FrameCount = stream.ReadUInt64();
			TimestampOffset = stream.ReadUInt64();
			ValueOffset = stream.ReadUInt64();
		}
	}
}
