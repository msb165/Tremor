using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Brass
{
	public class BrassRapier:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 69;
			Item.DamageType = DamageClass.Melee;
			Item.width = 52;
			Item.height = 54;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 12500;
			Item.rare = 5;
			Item.UseSound = SoundID.Item71;
			Item.shoot = ModContent.ProjectileType<Projectiles.BrassCog>();
			Item.shootSpeed = 10f;

			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brass Rapier");
			// Tooltip.SetDefault("Shoots spiky brass cogs on use");
		}

		public override void UpdateInventory(Player player)
		{
			if (player.HasBuffSafe(ModContent.BuffType<Buffs.SteamSwordBuff>()))
			{
				Item.damage = 80;
				Item.useTime = 15;
				Item.useAnimation = 15;
			}
			else
			{
				Item.damage = 65;
				Item.useTime = 25;
				Item.useAnimation = 25;
			}
		}
	}
}
