using EldanToolkit.Libraries.LibNexus.Core.Extensions;
using EldanToolkit.Libraries.LibNexus.Files;
using System;
using System.IO;
using System.Linq;
using System.Numerics;

namespace EldanToolkit.Libraries.LibNexus.Files.ModelFiles;

public class ModelLightHeader
{
	public ushort unkDBID { get; } // Signature?
	public ushort BigData { get; } // Seems to be involved in multiple lights in one model?
	public short unk01;
	public short unk02;
	public short unk03;
	public short[] values1; //39 array size
	public Vector4 UnkVec { get; }
	public Vector3 Color { get; }
	public AnimationTrackChunk Track1 { get; }
	public AnimationTrackChunk Track2 { get; }
	public AnimationTrackChunk Track3 { get; }

	public short[] values2; // 60 array size

	public AnimationTrackChunk Track4 { get; }
	public AnimationTrackChunk Track5 { get; }
	public AnimationTrackChunk Track6 { get; }

	public short[] values3; // 24 array size

	public ModelLightHeader(Stream stream)
	{
		unkDBID = stream.ReadUInt16();
		BigData = stream.ReadUInt16();
		unk01 = stream.ReadInt16();
		unk02 = stream.ReadInt16();
		unk03 = stream.ReadInt16();

		values1 = new short[39];
		for (int i = 0; i < 39; i++)
		{
			values1[i] = stream.ReadInt16();
		}

		Track1 = new AnimationTrackChunk(stream);
		Track2 = new AnimationTrackChunk(stream);
		Track3 = new AnimationTrackChunk(stream);

		values1 = new short[60];
		for (int i = 0; i < 60; i++)
		{
			values1[i] = stream.ReadInt16();
		}

		Track4 = new AnimationTrackChunk(stream);
		Track5 = new AnimationTrackChunk(stream);
		Track6 = new AnimationTrackChunk(stream);

		values1 = new short[24];
		for (int i = 0; i < 24; i++)
		{
			values1[i] = stream.ReadInt16();
		}
	}

	public static void Goto(Stream stream, string field, ulong position)
	{
		stream.Goto<ModelLightHeader>(field, position, Model.Debug);
	}
}
