using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EnchantedHourglass:TremorModItem
	{
		public override void SetDefaults()
		{
			//Item.melee = false;
			Item.DamageType = DamageClass.Magic;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 30000;
			Item.rare = 9;
			Item.expert = true;
			Item.UseSound = SoundID.Item4;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Enchanted Hourglass");
			// Tooltip.SetDefault("");
		}

		public override bool? UseItem(Player player)
		{
			if (Main.LocalPlayer.active && Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<Buffs.HealthRecharging>()) != -1)
			{
				Item.mana = 0;
				Item.healLife = 0;
			}
			else
			{
				player.AddBuff(ModContent.BuffType<Buffs.HealthRecharging>(), 1200, true);
				//Item.mana = 50;
				Item.healLife = 30;
			}
			return false;
		}
	}
}
