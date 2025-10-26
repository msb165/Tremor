using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Nitro:TremorModItem
	{
		public override bool CanEquipAccessory(Player player, int slot, bool modded)
		{
			for (int i = 0; i < player.armor.Length; i++)
			{
				MPlayer modPlayer = player.GetModPlayer<MPlayer>();
				if (modPlayer.nitro)
				{
					return false;
				}
			}
			return true;
		}

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 250000;
			Item.rare = 6;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Nitro");
			// Tooltip.SetDefault("Alchemical flasks leave death flames");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			player.AddBuff(ModContent.BuffType<Buffs.NitroBuff>(), 2);
			modPlayer.nitro = true;
		}
	}
}
