using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LauncherSAMPInt
{
    class Query : IDisposable
	{
        IPAddress address;
        private readonly int port = 0;
        private readonly DateTime[] timestamp = new DateTime[2];

        public Socket QSocket { get; set; }

        public Query(string address, int port = 7777)
		{
            QSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
            {
                SendTimeout = 200, ReceiveTimeout = 1500
            };
            try                                                                                                   
			{                                                                                              
				this.address = IPAddress.Parse(address);                                   
			}                                                                                            
			catch { return; }                                                                                   
        
			this.port = port;
		}
		
		public async Task<bool> Send()
		{
            bool result = false;
            await Task.Run(new Action(() =>
            {
                EndPoint endpoint;
                try
                {
                    endpoint = new IPEndPoint(address, port);
                }
                catch { return; }

                using (MemoryStream stream = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write("SAMP".ToCharArray());
                        Array.ForEach(address.ToString().Split('.'), x => writer.Write(Convert.ToByte(x)));
                        writer.Write((ushort)port);
                        writer.Write('i');
                        timestamp[0] = DateTime.Now;
                    }

                    try
                    {
                        QSocket.SendTo(stream.ToArray(), endpoint);
                        result = true;
                    }
                    catch { }

                }
            }));

            return await Task.FromResult(result);
		}

		async public Task<string[]> Recieve()
		{
            List<string> recieve_data = new List<string>();
            await Task.Run(new Action(() => {
                byte[] buffer = new byte[ushort.MaxValue];
                try
                {
                    EndPoint endpoint = new IPEndPoint(address, port);
                    QSocket.ReceiveFrom(buffer, ref endpoint);
                }
                catch { }
                timestamp[1] = DateTime.Now;
                using (MemoryStream stream = new MemoryStream(buffer))
                {
                    if (stream.Length <= 10) return;
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        reader.ReadBytes(10);
                        reader.ReadChar();
                        recieve_data.Add((reader.ReadByte().ToString() == "0") ? "Online" : "Protected");
                        string count_players = reader.ReadInt16().ToString() + " / " + reader.ReadInt16().ToString();
                        string hostname = new string(reader.ReadChars(reader.ReadInt32()));
                        recieve_data.Add(hostname);
                        recieve_data.Add(port.ToString());
                        recieve_data.Add(count_players);
                        string gamemode = new string(reader.ReadChars(reader.ReadInt32()));
                        string ping = timestamp[1].Subtract(timestamp[0]).Milliseconds.ToString();
                        recieve_data.Add(ping);
                        recieve_data.Add(gamemode);
                    }
                }
            }));
            return await Task.FromResult(recieve_data.ToArray());
		}

        public void Dispose() => ((IDisposable)QSocket).Dispose();
    }
}