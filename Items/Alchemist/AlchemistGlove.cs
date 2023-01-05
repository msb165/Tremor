using Terraria;
using Terraria.ModLoader;
using Tremor.Buffs;

namespace Tremor.Items.Alchemist
{
	public class AlchemistGlove:TremorModItem
	{
		public override bool CanEquipAccessory(Player player, int slot, bool modded)
		{
			for (int i = 0; i < player.armor.Length; i++)
			{
				MPlayer modPlayer = player.GetModPlayer<MPlayer>();
				if (modPlayer.glove)
				{
					return false;
				}
			}
			return true;
		}

		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 38;

			item.value = 1500000;
			item.rare = 7;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Master Alchemist Glove");
			Tooltip.SetDefault("Alchemic weapons throw two flasks instead of one");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			player.AddBuff(ModContent.BuffType<AlchemistGloveBuff>(), 2);
			modPlayer.glove = true;
		}
	}
}
