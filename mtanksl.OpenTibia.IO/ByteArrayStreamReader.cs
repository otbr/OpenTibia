﻿using System.Text;

namespace OpenTibia.IO
{
    public class ByteArrayStreamReader
    {
        public ByteArrayStreamReader(ByteArrayStream stream) : this(stream, Encoding.GetEncoding("ISO-8859-1") )
        {
            
        }

        public ByteArrayStreamReader(ByteArrayStream stream, Encoding encoding)
        {
            this.stream = stream;

            this.encoding = encoding;
        }

        private ByteArrayStream stream;

        public ByteArrayStream BaseStream
        {
            get
            {
                return stream;
            }
        }

        private Encoding encoding;

        public Encoding Encoding
        {
            get
            {
                return encoding;
            }
        }

        private int InternalReadInt32(int count)
        {
            int value = 0;

            for (int i = 0; i < count; i++)
            {
                value |= ( (int)stream.ReadByte() << (i * 8) );
            }

            return value;
        }

        private long InternalReadInt64(int count)
        {
            long value = 0;

            for (int i = 0; i < count; i++)
            {
                value |= ( (long)stream.ReadByte() << (i * 8) );
            }

            return value;
        }

        public byte ReadByte()
        {
            return stream.ReadByte();
        }
        
        public bool ReadBool()
        {
            return ReadByte() != 0x00;
        }
        
        public short ReadShort()
        {
            return (short)InternalReadInt32(2);
        }
        
        public ushort ReadUShort()
        {
            return (ushort)InternalReadInt32(2);
        }

        public int ReadInt()
        {
            return (int)InternalReadInt32(4);
        }

        public uint ReadUInt()
        {
            return (uint)InternalReadInt32(4);
        }

        public long ReadLong()
        {
            return (long)InternalReadInt64(8);
        }

        public ulong ReadULong()
        {
            return (ulong)InternalReadInt64(8);
        }

        private static object locker = new object();

        private static byte[] buffer = new byte[65535];

        public string ReadString()
        {
            int length = ReadUShort();

            if (length == 0)
            {
                return "";
            }
            else
            {
                return ReadString(length);
            }
        }

        public string ReadString(int length)
        {
            lock (locker)
            {
                stream.Read(buffer, 0, length);

                return encoding.GetString(buffer, 0, length);
            }
        }

        public byte[] ReadBytes(int length)
        {
            byte[] buffer = new byte[length]; 

            stream.Read(buffer, 0, buffer.Length);
            
            return buffer;
        }
    }
}