using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class OceanBate:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 168;
			Item.DamageType = DamageClass.Ranged;
			//Item.melee = false;
			Item.width = 28;
			Item.height = 52;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useAmmo = AmmoID.Arrow;
			Item.useStyle = 5;
			Item.shootSpeed = 30f;
			Item.knockBack = 3;
			Item.value = 85000;
			Item.rare = 10;
			Item.shoot = 408;
			Item.shootSpeed = 19f;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ocean Bate");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 408;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 25);
			recipe.AddIngredient(ItemID.Coral, 20);
			recipe.AddIngredient(ItemID.SharkFin, 8);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}

	}
}
