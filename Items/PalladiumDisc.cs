using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PalladiumDisc:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 36;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 20;
			Item.shootSpeed = 12f;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 3f;
			Item.shoot = ModContent.ProjectileType<Projectiles.PalladiumDiscPro>();
			Item.value = 27600;
			Item.rare = 4;
			Item.noUseGraphic = true;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Palladium Disc");
			// Tooltip.SetDefault("");
		}

		public override bool CanUseItem(Player player)
		{
			for (int i = 0; i < 1000; ++i)
			{
				if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == Item.shoot)
				{
					return false;
				}
			}
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.PalladiumBar, 12);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
