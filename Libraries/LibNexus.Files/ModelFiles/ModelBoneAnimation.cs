using EldanToolkit.Libraries.LibNexus.Core.Extensions;
using EldanToolkit.Libraries.LibNexus.Files;
using Godot;
using System;
using System.IO;

namespace EldanToolkit.Libraries.LibNexus.Files.ModelFiles;

public class ModelBoneAnimation
{
	public ModelBoneAnimation(Stream stream, ModelBoneHeader header)
	{
		if (header.Animation1.FrameCount != 0)
		{
			Goto(stream, nameof(header.Animation1.TimestampOffset), header.Animation1.TimestampOffset);
			for (ulong i = 0; i < header.Animation1.FrameCount; i++)
			{
				uint data = stream.ReadUInt32(); // TODO
			}
			stream.SkipPadding(16);

			Goto(stream, nameof(header.Animation1.ValueOffset), header.Animation1.ValueOffset);
			for (ulong i = 0; i < header.Animation1.FrameCount; i++)
			{
				byte[] data = stream.ReadBytes(6); // TODO
			}
			stream.SkipPadding(16);
		}

		if (header.Animation2.FrameCount != 0)
		{
			Goto(stream, nameof(header.Animation2.TimestampOffset), header.Animation2.TimestampOffset);
			for (ulong i = 0; i < header.Animation2.FrameCount; i++)
			{
				uint data = stream.ReadUInt32(); // TODO
			}
			stream.SkipPadding(16);

			Goto(stream, nameof(header.Animation2.ValueOffset), header.Animation2.ValueOffset);
			for (ulong i = 0; i < header.Animation2.FrameCount; i++)
			{
				byte[] data = stream.ReadBytes(6); // TODO
			}
			stream.SkipPadding(16);
		}

		if (header.Animation3.FrameCount != 0)
		{
			Goto(stream, nameof(header.Animation3.TimestampOffset), header.Animation3.TimestampOffset);
			for (ulong i = 0; i < header.Animation3.FrameCount; i++)
			{
				uint data = stream.ReadUInt32(); // TODO
			}
			stream.SkipPadding(16);

			Goto(stream, nameof(header.Animation3.ValueOffset), header.Animation3.ValueOffset);
			for (ulong i = 0; i < header.Animation3.FrameCount; i++)
			{
				byte[] data = stream.ReadBytes(6); // TODO
			}
			stream.SkipPadding(16);
		}

		if (header.Animation4.FrameCount != 0)
		{
			Goto(stream, nameof(header.Animation4.TimestampOffset), header.Animation4.TimestampOffset);
			for (ulong i = 0; i < header.Animation4.FrameCount; i++)
			{
				uint data = stream.ReadUInt32(); // TODO
			}
			stream.SkipPadding(16);

			Goto(stream, nameof(header.Animation4.ValueOffset), header.Animation4.ValueOffset);
			for (ulong i = 0; i < header.Animation4.FrameCount; i++)
			{
				byte[] data = stream.ReadBytes(6); // TODO
			}
			stream.SkipPadding(16);
		}

		if (header.Animation5.FrameCount != 0)
		{
			Goto(stream, nameof(header.Animation5.TimestampOffset), header.Animation5.TimestampOffset);
			for (ulong i = 0; i < header.Animation5.FrameCount; i++)
			{
				uint data = stream.ReadUInt32(); // TODO
			}
			stream.SkipPadding(16);

			Goto(stream, nameof(header.Animation5.ValueOffset), header.Animation5.ValueOffset);
			for (ulong i = 0; i < header.Animation5.FrameCount; i++)
			{
				byte[] data = stream.ReadBytes(8); // TODO
			}
			stream.SkipPadding(16);
		}

		if (header.Animation6.FrameCount != 0)
		{
			Goto(stream, nameof(header.Animation6.TimestampOffset), header.Animation6.TimestampOffset);
			for (ulong i = 0; i < header.Animation6.FrameCount; i++)
			{
				uint data = stream.ReadUInt32(); // TODO
			}
			stream.SkipPadding(16);

			Goto(stream, nameof(header.Animation6.ValueOffset), header.Animation6.ValueOffset);
			for (ulong i = 0; i < header.Animation6.FrameCount; i++)
			{
				byte[] data = stream.ReadBytes(8); // TODO
			}
			stream.SkipPadding(16);
		}

		if (header.Animation7.FrameCount != 0)
		{
			Goto(stream, nameof(header.Animation7.TimestampOffset), header.Animation7.TimestampOffset);
			for (ulong i = 0; i < header.Animation7.FrameCount; i++)
			{
				uint data = stream.ReadUInt32(); // TODO
			}
			stream.SkipPadding(16);

			Goto(stream, nameof(header.Animation7.ValueOffset), header.Animation7.ValueOffset);
			for (ulong i = 0; i < header.Animation7.FrameCount; i++)
			{
				byte[] data = stream.ReadBytes(12); // TODO
			}
			stream.SkipPadding(16);
		}

		if (header.Animation8.FrameCount != 0)
		{
			Goto(stream, nameof(header.Animation8.TimestampOffset), header.Animation8.TimestampOffset);
			for (ulong i = 0; i < header.Animation8.FrameCount; i++)
			{
				uint data = stream.ReadUInt32(); // TODO
			}
			stream.SkipPadding(16);

			Goto(stream, nameof(header.Animation8.ValueOffset), header.Animation8.ValueOffset);
			for (ulong i = 0; i < header.Animation8.FrameCount; i++)
			{
				byte[] data = stream.ReadBytes(12); // TODO
			}
			stream.SkipPadding(16);
		}
	}

	public static void Goto(Stream stream, string field, ulong position)
	{
		stream.Goto<ModelBoneAnimation>(field, position, true);
	}
}
