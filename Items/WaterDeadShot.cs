using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class WaterDeadShot:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 14;
			Item.width = 18;
			Item.height = 48;
			Item.useTime = 30;
			Item.DamageType = DamageClass.Ranged;
			Item.shoot = 27;

			Item.shootSpeed = 23f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 250;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = 2;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Water Dead Shot");
			/* Tooltip.SetDefault("Shoots water streams\n" +
"Uses arrows as ammo"); */
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 27;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 8);
			recipe.AddIngredient(ItemID.Sapphire, 10);
			recipe.AddIngredient(ItemID.GoldBar, 6);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 8);
			recipe.AddIngredient(ItemID.Sapphire, 10);
			recipe.AddIngredient(ItemID.PlatinumBar, 6);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
