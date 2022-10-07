using System;
using System.IO;
using System.Text;
using System.Linq;
using System.IO.Compression;
using System.Collections.Generic;

namespace YuRIS.Package
{
    public class YPF
    {
        public static byte[] YPFHeader;


        static YPF()
        {
            YPF.YPFHeader = new byte[] { 89, 80, 70, 0 };
        }

        public YPF()
        {
        }

        public static byte[] GetNameLengthTable(int engine)
        {
            byte[] name;
            name = (engine < 500 ? new byte[] { 0, 1, 2, 72, 4, 5, 53, 7, 8, 11, 10, 9, 16, 19, 14, 15, 12, 25, 18, 13, 20, 27, 22, 23, 24, 17, 26, 21, 30, 29, 28, 31, 35, 33, 34, 32, 36, 37, 41, 39, 40, 38, 42, 43, 47, 45, 50, 44, 48, 49, 46, 51, 52, 6, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 3, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255 } : new byte[] { 0, 1, 2, 10, 4, 5, 53, 7, 8, 11, 3, 9, 16, 19, 14, 15, 12, 24, 18, 13, 46, 27, 22, 23, 17, 25, 26, 21, 30, 29, 28, 31, 35, 33, 34, 32, 36, 37, 41, 39, 40, 38, 42, 43, 47, 45, 20, 44, 48, 49, 50, 51, 52, 6, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255 });
            return name;
        }

        public static YPF ReadFile(BinaryReader reader, Func<byte[], uint> nameHash = null, Func<byte[], uint> dataHash = null)
        {
            if (Encoding.UTF8.GetString(reader.ReadBytes(3)) != "YPF" || reader.ReadByte() != 0)
            {
                throw new InvalidDataException("YPF header mismatch");
            }

            int version = reader.ReadInt32();
            if (version < 234 || version > 500)
            {
                throw new InvalidDataException("Unsupported YPF engine version: " + version);
            }

            var result = new YPF();
            int count = reader.ReadInt32();
            if (count <= 0)
            {
                throw new InvalidDataException("YPF structure mismatch");
            }
            
            reader.BaseStream.Position = 32;

            List<long> offsets = new List<long>();
            for (int i = 0; i < count; i++)
            {
                uint hash = reader.ReadUInt32();
                int length = reader.ReadByte() ^ 0xff & 0xff;
                length = YPF.GetNameLengthTable(version)[length];

                byte[] name = reader.ReadBytes(length);
                for (int j = 0; j < (int)name.Length; j++)
                {
                    byte num4 = (byte)(~name[j]);
                    if (version == 290)
                    {
                        num4 = (byte)(num4 ^ 64);
                    }
                    else if (version == 500)
                    {
                        num4 = (byte)(num4 ^ 54);
                    }
                    name[j] = num4;
                }
                if (nameHash != null && nameHash(name) != hash)
                {
                    throw new InvalidDataException("File name hash mismatch");
                }

                var entry = new YPFEntry()
                {
                    Name = Encoding.GetEncoding("SHIFT-JIS").GetString(name),
                    Type = (ResourceType)reader.ReadByte(),
                    Compressed = reader.ReadByte() != 0,
                    Size = reader.ReadInt32(),
                    CompressedSize = reader.ReadInt32()
                };
                result.Entries.Add(entry);

                if (entry.Size < 0 || (entry.Size != entry.CompressedSize && !entry.Compressed))
                {
                    throw new InvalidDataException("YPF structure mismatch");
                }

                offsets.Add(version >= 480 ? reader.ReadInt64() : reader.ReadInt32());
                entry.Hash = version >= 473 ? reader.ReadUInt32() : 0;
            }
            for (int i = 0; i < count; i++)
            {
                reader.BaseStream.Position = offsets[i];
                var entry = result.Entries[i];
                var data = reader.ReadBytes(entry.CompressedSize);
                if (dataHash != null && entry.Hash!=0 && dataHash(data) != entry.Hash)
                {
                    throw new InvalidDataException("File data hash mismatch");
                }
                if (entry.Compressed)
                {
                    if (data[0] != 0x78)
                    {
                        throw new InvalidDataException("Invalid compressed data");
                    }
                    using (var ms = new MemoryStream())
                    using (var input = new MemoryStream(data))
                    using (var deflate = new DeflateStream(input, CompressionMode.Decompress, false))
                    {
                        input.Position = 2;
                        deflate.CopyTo(ms);
                        if (ms.Length != entry.Size)
                        {
                            throw new InvalidDataException("YPF decompression failed");
                        }
                        entry.SetData(ms.ToArray());
                    }
                }
                else
                {
                    entry.SetData(data);
                }
            }
            return result;
        }

        public List<YPFEntry> Entries = new List<YPFEntry>();

        public void Write(BinaryWriter writer, int engine, Func<byte[], uint> nameHash, Func<byte[], uint> dataHash)
        {
            writer.Write(YPFHeader);
            writer.Write(engine);
            writer.Write(Entries.Count);
            writer.BaseStream.Position = 32;

            List<long> entryPosition = new List<long>();
            foreach (var entry in Entries)
            {
                var name = Encoding.GetEncoding("SHIFT-JIS").GetBytes(entry.Name);
                writer.Write(nameHash(name));
                int length = (int)name.Length;
                if (length > 255)
                {
                    throw new InvalidDataException("File name can't be longer than 0xFF");
                }
                length = ~(byte)(YPF.GetNameLengthTable(engine).ToList<byte>().IndexOf((byte)length) - 256);
                writer.Write((byte)length);
                for (int i = 0; i < (int)name.Length; i++)
                {
                    byte num = name[i];
                    if (engine == 290)
                    {
                        num = (byte)(num ^ 64);
                    }
                    else if (engine == 500)
                    {
                        num = (byte)(num ^ 54);
                    }
                    name[i] = (byte)(~num);
                }
                writer.Write(name);
                writer.Write((byte)entry.Type);
                writer.Write(entry.Compressed);
                writer.Write(entry.Size);

                entryPosition.Add(writer.BaseStream.Position);
                writer.Write(0); // Compressed size placeholder
                writer.Write(0L); // Data offset placeholder
                writer.Write(0); // Hash placeholder
            }

            for (int i = 0; i < Entries.Count; i++)
            {
                var entry = Entries[i];
                var data = entry.Data;
                if (entry.Compressed)
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.WriteByte(0x78);
                        ms.WriteByte(0xDA);
                        using (var deflate = new DeflateStream(ms, CompressionLevel.Optimal, true))
                        {
                            deflate.Write(entry.Data, 0, entry.Size);
                        }
                        data = ms.ToArray();
                    }
                }
                writer.Write(data);

                long dataOffset = writer.BaseStream.Position;
                writer.BaseStream.Position = entryPosition[i];

                entry.CompressedSize = data.Length;
                writer.Write(entry.CompressedSize);
                if(engine >= 480)
                {
                    writer.Write(dataOffset - data.Length);
                }
                else
                {
                    writer.Write((int)(dataOffset - data.Length));
                }
                writer.Write(dataHash(data));

                writer.BaseStream.Position = dataOffset;
            }
        }
    }
}
