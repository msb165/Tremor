using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor
{
	public class TremorGlowMask : ModPlayer
	{
		private static readonly Dictionary<int, Texture2D> ItemGlowMask = new Dictionary<int, Texture2D>();

		internal static void Unload()
		{
			ItemGlowMask.Clear();
		}

		//TODO: [Skipped for 1.4] Fix glowmasks, replace these with multiple PlayerDrawLayer classes
		public static void AddGlowMask(ModItem item, string texturePath = null)
		{
			//ItemGlowMask[item.Item.type]=item.Mod.Assets.Request<Texture2D>(texturePath??(item.Texture+"Glow"), AssetRequestMode.ImmediateLoad).Value;
		}

		public static void AddGlowMask(ModItem item, EquipType equipType)
		{
			//ItemGlowMask[item.Item.type]=item.Mod.Assets.Request<Texture2D>($"{item.Texture}_{equipType}Glow", AssetRequestMode.ImmediateLoad).Value;
		}

		//public override void ModifyDrawLayers(List<PlayerLayer> layers)
		//{
		//	int slotLegs = Player.armor[12].IsAir ? 2 : 12;
		//	int slotBody = Player.armor[11].IsAir ? 1 : 11;
		//	int slotHead = Player.armor[10].IsAir ? 0 : 10;
			
		//	if (Player.armor[slotLegs].type >= ItemID.Count && ItemGlowMask.TryGetValue(Player.armor[slotLegs].type, out Texture2D textureLegs))//Legs
		//	{
		//		InsertAfterVanillaLayer(layers, "Legs", new PlayerLayer(Mod.Name, "GlowMaskLegs", delegate (PlayerDrawInfo info)
		//		{
		//			TremorUtils.DrawArmorGlowMask(EquipType.Legs, textureLegs, info);
		//		}));
		//	}

		//	if (Player.armor[slotBody].type >= ItemID.Count && ItemGlowMask.TryGetValue(Player.armor[slotBody].type, out Texture2D textureBody))//Body
		//	{
		//		InsertAfterVanillaLayer(layers, "Body", new PlayerLayer(Mod.Name, "GlowMaskBody", delegate (PlayerDrawInfo info)
		//		{
		//			TremorUtils.DrawArmorGlowMask(EquipType.Body, textureBody, info);
		//		}));
		//	}

		//	if (Player.armor[slotHead].type >= ItemID.Count && ItemGlowMask.TryGetValue(Player.armor[slotHead].type, out Texture2D textureHead))//Head
		//	{
		//		InsertAfterVanillaLayer(layers, "Head", new PlayerLayer(Mod.Name, "GlowMaskHead", delegate (PlayerDrawInfo info)
		//		{
		//			TremorUtils.DrawArmorGlowMask(EquipType.Head, textureHead, info);
		//		}));
		//	}

		//	if (Player.HeldItem.type >= ItemID.Count && ItemGlowMask.TryGetValue(Player.HeldItem.type, out Texture2D textureItem))//HeldItem
		//	{
		//		InsertAfterVanillaLayer(layers, "HeldItem", new PlayerLayer(Mod.Name, "GlowMaskHeldItem", delegate (PlayerDrawInfo info)
		//		{
		//			TremorUtils.DrawItemGlowMask(textureItem, info);
		//		}));
		//	}
		//}

		//public static void InsertAfterVanillaLayer(List<PlayerLayer> layers, string vanillaLayerName, PlayerLayer newPlayerLayer)
		//{
		//	for (int i = 0; i < layers.Count; i++)
		//	{
		//		if (layers[i].Name == vanillaLayerName && layers[i].mod == "Terraria")
		//		{
		//			layers.Insert(i + 1, newPlayerLayer);
		//			return;
		//		}
		//	}
		//	layers.Add(newPlayerLayer);
		//}
	}

	//public class LegGlowMaskDrawLayer : PlayerDrawLayer
	//{

	//}
}
