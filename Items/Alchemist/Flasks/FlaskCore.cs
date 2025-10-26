using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Alchemist.Flasks
{
	public class FlaskCore:TremorModItem
	{
		public override bool CanEquipAccessory(Player player, int slot, bool modded)
			=> !MPlayer.GetModPlayer(player).core;

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 24;

			Item.value = 50000;
			Item.rare = 6;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flask Core");
			// Tooltip.SetDefault("Flasks now have autoreuse");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(ModContent.BuffType<Buffs.FlaskCoreBuff>(), 2);
		}
	}
}
