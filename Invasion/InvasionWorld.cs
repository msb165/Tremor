using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Tremor.Invasion
{
	public class InvasionWorld : ModSystem
	{
		public static int CyberWrathPoints = 0; // Is set once to Points1, never used. Delete ?? (?)
		public static int CyberWrathPoints1;
		public static bool CyberWrath;

		public override void OnWorldLoad()
		{
			CyberWrathPoints1 = 0;
			CyberWrath = false;
		}

		/*public override void SaveCustomData(BinaryWriter writer)
		{
			writer.Write(saveVersion);
			writer.Write(CyberWrath);
			writer.Write(CyberWrathPoints1);
		} */

		public override void SaveWorldData(TagCompound tag)
		{
			tag.Add("CyberWrath", CyberWrath);
			tag.Add("CyberWrathPoints1", CyberWrathPoints1);
		}

		public override void LoadWorldData(TagCompound tag)
		{
			CyberWrath = tag.GetBool("CyberWrath");
			CyberWrathPoints1 = tag.GetAsInt("CyberWrathPoints1");
		}

		public override void NetSend(BinaryWriter writer)
		{
			writer.Write(CyberWrath);
			writer.Write(CyberWrathPoints1);
		}

		public override void NetReceive(BinaryReader reader)
		{
			CyberWrath = reader.ReadBoolean();
			CyberWrathPoints1 = reader.ReadInt32();
		}

		//public override void LoadLegacy(BinaryReader reader)
		//{
		//	int loadVersion = reader.ReadInt32();
		//	if (loadVersion == 0)
		//	{
		//		// ? potential trouble
		//		BitsByte flags = reader.ReadByte();
		//		CyberWrath = flags[0];
		//		CyberWrathPoints1 = reader.ReadInt32();
		//	}
		//	else
		//	{
		//		ErrorLogger.Log("Tremor: Unknown loadVersion: " + loadVersion);
		//	}
		//}
	}
}
