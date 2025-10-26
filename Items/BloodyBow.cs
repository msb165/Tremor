using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Steel;

namespace Tremor.Items
{
	public class BloodyBow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 59;
			Item.width = 16;
			Item.height = 32;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 30;
			Item.shoot = 1;

			Item.shootSpeed = 60f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 1040;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = 6;
			Item.crit = 7;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bloody Bow");
			// Tooltip.SetDefault("Launches arrows at lightning speed!");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ModContent.ProjectileType<Projectiles.BloodyArrow>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SkullTeeth>(), 4);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
