using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BottledSpirit:TremorModItem
	{

		public override bool CanEquipAccessory(Player player, int slot, bool modded)
		{
			for (int i = 0; i < player.armor.Length; i++)
			{
				MPlayer modPlayer = player.GetModPlayer<MPlayer>();
				if (modPlayer.spirit)
				{
					return false;
				}
			}
			return true;
		}

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 44;

			item.value = 60000;
			item.rare = 7;
			item.accessory = true;
			item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottled Spirit");
			Tooltip.SetDefault("Using flask also spawns two homing souls\n" +
"Damage of the souls scales on flask damage");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			player.AddBuff(ModContent.BuffType<Buffs.BottledSpirit>(), 2);
			modPlayer.spirit = true;
		}
	}
}
