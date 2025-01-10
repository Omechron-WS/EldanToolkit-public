using EldanToolkit.Libraries.LibNexus.Files;
using LibNexus.Core.Extensions;
using LibNexus.Files.ModelFiles;
using SharpCompress.Compressors.Xz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldanToolkit.Libraries.LibNexus.Files.ModelFiles
{
	public class ModelLightAnimation
	{
		public uint[] Animation2Times { get; }
		public uint[] Animation2Values { get; }
		public uint[] Animation3Times { get; }
		public Half[] Animation3Values { get; }

		public ModelLightAnimation(Stream stream, ModelLightHeader header)
		{
			Goto(stream, nameof(header.Track2.TimestampOffset), header.Track2.TimestampOffset);
			Animation2Times = new uint[header.Track2.FrameCount];
			for (var i = 0u; i < header.Track2.FrameCount; i++)
			{
				Animation2Times[i] = stream.ReadUInt32();
			}
			stream.SkipPadding(16);

			Goto(stream, nameof(header.Track2.ValueOffset), header.Track2.ValueOffset);
			Animation2Values = new uint[header.Track2.FrameCount];
			for (var i = 0u; i < header.Track2.FrameCount; i++)
			{
				Animation2Values[i] = stream.ReadUInt32();
			}
			stream.SkipPadding(16);


			Goto(stream, nameof(header.Track3.TimestampOffset), header.Track3.TimestampOffset); // Often 432?
			Animation3Times = new uint[header.Track3.FrameCount];
			for (var i = 0u; i < header.Track3.FrameCount; i++)
			{
				Animation3Times[i] = stream.ReadUInt32();
			}
			stream.SkipPadding(16);

			Goto(stream, nameof(header.Track3.ValueOffset), header.Track3.ValueOffset);
			Animation3Values = new Half[header.Track3.FrameCount];
			for (var i = 0u; i < header.Track3.FrameCount; i++)
			{
				Animation3Values[i] = stream.ReadHalf();
			}
			stream.SkipPadding(16);



			//stream.Position = 8 + BigData * 400; // from header

			//UnkVec = new Vector4(stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte() / 255f, stream.ReadByte() / 255f);


			// Vector at 416?

			// Repeating pattern, 280, 304, 328. Does not seem to shift.

			// Repeating pattern, 416, 448, 480, 512, 544, 576, 608. Not always there. Found at 576, 608, 640 in soft_throb
			// Pattern 432 - 508, 4 bytes. 19 units. 136 has a 19.
			// 508-512 is padding?
		}

		public static void Goto(Stream stream, string field, ulong position)
		{
			stream.Goto<ModelLightHeader>(field, position, Model.Debug);
		}
	}
}
