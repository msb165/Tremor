using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EnchantedHourglass:TremorModItem
	{
		public override void SetDefaults()
		{
			//item.melee = false;
			item.DamageType = DamageClass.Magic;
			item.width = 50;
			item.height = 55;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 30000;
			item.rare = 9;
			item.expert = true;
			item.UseSound = SoundID.Item4;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enchanted Hourglass");
			Tooltip.SetDefault("");
		}

		public override bool? UseItem(Player player)
		{
			if (Main.LocalPlayer.active && Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<Buffs.HealthRecharging>()) != -1)
			{
				item.mana = 0;
				item.healLife = 0;
			}
			else
			{
				player.AddBuff(ModContent.BuffType<Buffs.HealthRecharging>(), 1200, true);
				//item.mana = 50;
				item.healLife = 30;
			}
			return false;
		}
	}
}
