using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Tremor.ZombieEvent
{
	public class ZWorld : ModSystem
	{
	    private const int saveVersion = 0;
        public static int ZPoints;
        public static bool ZInvasion;

		//public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight){}

		//public override void PostWorldGen(){}

		public override void OnWorldLoad()
        {
			ZPoints = 0;
			ZInvasion = false;
        }

        //public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts){}
		
		public override void SaveWorldData(TagCompound tag)
		{
			var downed = new List<string>();
			//var downed_ = new List<int>();
			if (ZInvasion) downed.Add("boolWrath");
			if (ZPoints != -1 && ZInvasion) downed.Add("intWrath");

			tag.Add("downed", downed);
		}
		
		public override void NetSend(BinaryWriter writer)
		{
			writer.Write(ZInvasion);
			writer.Write(ZPoints);
		}

		public override void NetReceive(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			flags[0] = ZInvasion;
			ZPoints = reader.ReadInt32();
		}
		
		public override void LoadWorldData(TagCompound tag)
		{
			var downed = tag.GetList<string>("downed");
			//CyberWrathPoints1 = downed.Contains("intWrath");
			ZInvasion = downed.Contains("boolWrath");
		} 

		//public override void LoadLegacy(BinaryReader reader)
		//{
		//	int loadVersion = reader.ReadInt32();
		//	if (loadVersion == 0)
		//	{
		//		BitsByte flags = reader.ReadByte();
		//		ZInvasion = flags[0];
		//		ZPoints = reader.ReadInt32();
		//	}
		//	else
		//	{
		//		ErrorLogger.Log("Tremor: Unknown loadVersion: " + loadVersion);
		//	}
		//}	
	}
}
