using ONI_Together.DebugTools;
using ONI_Together.Menus;
using ONI_Together.Networking.Packets.Architecture;
using System.IO;
using Shared.Profiling;

namespace ONI_Together.Networking.Packets.Core
{
	public class AllClientsReadyPacket : IPacket, IAllowedWithoutWorldPacket
	{
		public ulong SynchronizationId;

		public void Serialize(BinaryWriter writer)
		{
			writer.Write(SynchronizationId);
		}

		public void Deserialize(BinaryReader reader)
		{
			SynchronizationId = reader.ReadUInt64();
		}

		public void OnDispatched()
		{
			using var _ = Profiler.Scope();

			if (MultiplayerSession.IsHost || !GameClient.CompleteSynchronization(SynchronizationId))
				return;

			DebugConsole.Log("[AllClientsReadyPacket] Synchronization completed; closing overlay");
			ProcessAllReady();
		}

		public static void ProcessAllReady()
		{
			using var _ = Profiler.Scope();

			MultiplayerOverlay.Show(STRINGS.UI.MP_OVERLAY.SYNC.FINALIZING_SYNC);
            MultiplayerOverlay.Close();
		}
	}
}
