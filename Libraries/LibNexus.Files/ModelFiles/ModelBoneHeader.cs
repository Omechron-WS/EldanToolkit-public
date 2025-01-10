using EldanToolkit.Libraries.LibNexus.Files.ModelFiles;
using LibNexus.Core.Extensions;
using System;
using System.IO;
using System.Numerics;

namespace LibNexus.Files.ModelFiles;

public class ModelBoneHeader
{
	public Matrix4x4 Rotation { get; set; }
	public Matrix4x4 Transform { get; set; }
	public Matrix4x4 InverseTransform { get; set; }
	public Vector3 Origin { get; set; }

	public AnimationTrackChunk Animation1 { get; set; }
	public AnimationTrackChunk Animation2 { get; set; }
	public AnimationTrackChunk Animation3 { get; set; }
	public AnimationTrackChunk Animation4 { get; set; }
	public AnimationTrackChunk Animation5 { get; set; }
	public AnimationTrackChunk Animation6 { get; set; }
	public AnimationTrackChunk Animation7 { get; set; }
	public AnimationTrackChunk Animation8 { get; set; }

	public Int16 unk1;
	public UInt16 unk2;
    public Int16 unk3;
    public UInt16 unk4;
	public byte[] unk5;

	public ModelBoneHeader(Stream stream)
	{
		unk1 = stream.ReadInt16(); // TODO id?
		unk2 = stream.ReadUInt16(); // TODO flags?
		unk3 = stream.ReadInt16(); // TODO parent?
		unk4 = stream.ReadUInt16(); // TODO mesh?

		Rotation = new Matrix4x4(stream.ReadUInt8(), 0, stream.ReadUInt8(), 0, 0, 1, 0, 0, stream.ReadUInt8(), 0, stream.ReadUInt8(), 0, 0, 0, 0, 1);
		unk5 = stream.ReadBytes(4); // TODO

		Animation1 = new AnimationTrackChunk(stream);
		Animation2 = new AnimationTrackChunk(stream);
		Animation3 = new AnimationTrackChunk(stream);
		Animation4 = new AnimationTrackChunk(stream);
		Animation5 = new AnimationTrackChunk(stream);
		Animation6 = new AnimationTrackChunk(stream);
		Animation7 = new AnimationTrackChunk(stream);
		Animation8 = new AnimationTrackChunk(stream);

		Transform = new Matrix4x4(
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle()
		);

		InverseTransform = new Matrix4x4(
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle(),
			stream.ReadSingle()
		);

		Origin = new Vector3(stream.ReadSingle(), stream.ReadSingle(), stream.ReadSingle());
	}
}
