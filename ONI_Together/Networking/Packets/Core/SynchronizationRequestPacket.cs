using System.IO;
using ONI_Together.Networking.Packets.Architecture;

namespace ONI_Together.Networking.Packets.Core
{
	public class SynchronizationRequestPacket : IPacket, IAllowedWithoutWorldPacket
	{
		public ulong Requester;

		public void Serialize(BinaryWriter writer) => writer.Write(Requester);
		public void Deserialize(BinaryReader reader) => Requester = reader.ReadUInt64();
		public void OnDispatched() => ReadyManager.RequestSynchronization(Requester);
	}
}
