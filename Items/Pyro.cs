using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Pyro:TremorModItem
	{

		public override bool CanEquipAccessory(Player player, int slot, bool modded)
		{
			for (int i = 0; i < player.armor.Length; i++)
			{
				MPlayer modPlayer = player.GetModPlayer<MPlayer>();
				if (modPlayer.pyro)
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

			Item.value = 300000;
			Item.rare = 5;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Pyro");
			// Tooltip.SetDefault("Alchemical flasks leaves an explosion");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			player.AddBuff(ModContent.BuffType<Buffs.PyroBuff>(), 2);
			modPlayer.pyro = true;
		}
	}
}
