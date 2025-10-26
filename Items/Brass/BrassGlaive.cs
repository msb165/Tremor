using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Brass
{
	public class BrassGlaive:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 60;
			Item.width = 76;
			Item.height = 78;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<Projectiles.BrassGlaive>();
			Item.shootSpeed = 3f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 1000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brass Glaive");
			// Tooltip.SetDefault("");
		}

		public override void UpdateInventory(Player player)
		{
			if (player.HasBuffSafe(ModContent.BuffType<Buffs.SteamSwordBuff>()))
			{
				Item.damage = 85;
			}
			else
			{
				Item.damage = 60;
			}
		}
	}
}
