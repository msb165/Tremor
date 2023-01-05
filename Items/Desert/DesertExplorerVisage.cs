using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Desert
{
	[AutoloadEquip(EquipType.Head)]
	public class DesertExplorerVisage:TremorModItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 22;
			item.value = 15000;
			item.rare = 8;
			item.defense = 11;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Explorer Visage");
			Tooltip.SetDefault("15% increased alchemical critical strike chance");
			TremorGlowMask.AddGlowMask(this, EquipType.Head);
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowSubtle = true;
			player.armorEffectDrawOutlines = true;
		}

		public override void DrawArmorColor(Player drawPlayer, float shadow, ref Color color, ref int glowMask, ref Color glowMaskColor)
		{
			glowMaskColor = Color.White;
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<MPlayer>().alchemicalCrit += 15;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<DesertExplorerBreastplate>() && legs.type == ModContent.ItemType<DesertExplorerGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "When a flask explodes a wasp appears to attack enemies";
			player.AddBuff(ModContent.BuffType<Buffs.DesertEmperorSetBuff>(), 4);
		}
	}
}
