using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
 
namespace SAMP
{
    class Query : IDisposable
	{
		Socket qSocket;
		IPAddress address;
		int _port = 0, _count = 0;
		string[] results;
        DateTime[] timestamp = new DateTime[2];
	

		public Query(string addr, int port = 7777)
		{
			qSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); 
			qSocket.SendTimeout = 50;
			qSocket.ReceiveTimeout = 500;                                                                             
			try                                                                                                   
			{                                                                                              
				address = IPAddress.Parse(addr);                                   
			}                                                                                            
			catch { return; }                                                                                   
        
			_port = port;
		}
		

		public bool Send(char opcode)
		{
                EndPoint endpoint;
                try
                {
                    endpoint = new IPEndPoint(address, _port);
                }
                catch
                { return false; }
                using (MemoryStream stream = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write("SAMP".ToCharArray());
                        string[] SplitIP = address.ToString().Split('.');
                        for (int i = 0; i < 4; i++)
                        try
                        {
                            writer.Write(Convert.ToByte(SplitIP[i]));
                        }
                        catch { }
                        
                        writer.Write((ushort)_port);
                        writer.Write(opcode);
                        if (opcode == 'p')
                            writer.Write("1337".ToCharArray());

                        timestamp[0] = DateTime.Now;
                    }


                    try {
                          qSocket.SendTo(stream.ToArray(), endpoint);
                          return true;
                        }
                    catch{ }

                }
            
            return false;
		}

		public string[] Recieve()
		{

			_count = 0;
            byte[] rBuffer = new byte[UInt16.MaxValue];
            try
            {
                EndPoint endpoint = new IPEndPoint(address, _port);
                qSocket.ReceiveFrom(rBuffer, ref endpoint);
            }
            catch { }
				timestamp[1] = DateTime.Now;
				using (MemoryStream stream = new MemoryStream(rBuffer))
				  using (BinaryReader reader = new BinaryReader(stream)){
                      if (stream.Length <= 10) return null;
						reader.ReadBytes(10);
						switch (reader.ReadChar())
						{
							case 'i':
								{
									results = new string[8];
									results[_count++] = reader.ReadByte().ToString(); 
									results[_count++] = reader.ReadInt16().ToString(); 
									results[_count++] = reader.ReadInt16().ToString(); 
									results[_count++] = new string(reader.ReadChars(reader.ReadInt32())); // hostname
									results[_count++] = new string(reader.ReadChars(reader.ReadInt32()));
                                    return results;
								}
                            case 'p':
								{
                                    results = new string[1];
								    results[0] = timestamp[1].Subtract(timestamp[0]).Milliseconds.ToString();
                                            if (results[0] == "0" || results[0] == " ") results[0] = "1";
                                    return results;
								}
 
							default:
                                    return null;
						}
					}
		}
        public void Dispose()
        {
            ((IDisposable)qSocket).Dispose();
        }
    }
}