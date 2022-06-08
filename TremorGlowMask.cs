using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
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

		public static void AddGlowMask(ModItem item, string texturePath = null)
		{
			ItemGlowMask[item.item.type]=ModContent.GetTexture(texturePath??(item.Texture+"Glow"));
		}

		public static void AddGlowMask(ModItem item, EquipType equipType)
		{
			ItemGlowMask[item.item.type]=ModContent.GetTexture($"{item.Texture}_{equipType}Glow");
		}

		public override void ModifyDrawLayers(List<PlayerLayer> layers)
		{
			int slotLegs = player.armor[12].IsAir ? 2 : 12;
			int slotBody = player.armor[11].IsAir ? 1 : 11;
			int slotHead = player.armor[10].IsAir ? 0 : 10;
			
			if (player.armor[slotLegs].type >= ItemID.Count && ItemGlowMask.TryGetValue(player.armor[slotLegs].type, out Texture2D textureLegs))//Legs
			{
				InsertAfterVanillaLayer(layers, "Legs", new PlayerLayer(mod.Name, "GlowMaskLegs", delegate (PlayerDrawInfo info)
				{
					TremorUtils.DrawArmorGlowMask(EquipType.Legs, textureLegs, info);
				}));
			}

			if (player.armor[slotBody].type >= ItemID.Count && ItemGlowMask.TryGetValue(player.armor[slotBody].type, out Texture2D textureBody))//Body
			{
				InsertAfterVanillaLayer(layers, "Body", new PlayerLayer(mod.Name, "GlowMaskBody", delegate (PlayerDrawInfo info)
				{
					TremorUtils.DrawArmorGlowMask(EquipType.Body, textureBody, info);
				}));
			}

			if (player.armor[slotHead].type >= ItemID.Count && ItemGlowMask.TryGetValue(player.armor[slotHead].type, out Texture2D textureHead))//Head
			{
				InsertAfterVanillaLayer(layers, "Head", new PlayerLayer(mod.Name, "GlowMaskHead", delegate (PlayerDrawInfo info)
				{
					TremorUtils.DrawArmorGlowMask(EquipType.Head, textureHead, info);
				}));
			}

			if (player.HeldItem.type >= ItemID.Count && ItemGlowMask.TryGetValue(player.HeldItem.type, out Texture2D textureItem))//HeldItem
			{
				InsertAfterVanillaLayer(layers, "HeldItem", new PlayerLayer(mod.Name, "GlowMaskHeldItem", delegate (PlayerDrawInfo info)
				{
					TremorUtils.DrawItemGlowMask(textureItem, info);
				}));
			}
		}

		public static void InsertAfterVanillaLayer(List<PlayerLayer> layers, string vanillaLayerName, PlayerLayer newPlayerLayer)
		{
			for (int i = 0; i < layers.Count; i++)
			{
				if (layers[i].Name == vanillaLayerName && layers[i].mod == "Terraria")
				{
					layers.Insert(i + 1, newPlayerLayer);
					return;
				}
			}
			layers.Add(newPlayerLayer);
		}
	}
}
