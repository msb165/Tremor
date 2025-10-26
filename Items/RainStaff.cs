using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RainStaff:TremorModItem
	{
		const float RainTimeInMinuts = 15; // Кол-во минут
		const float DistortPercent = 0.1f; // Процент отклонения времени (разброса)

		public override void SetDefaults()
		{

			Item.width = 44;
			Item.height = 48;

			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 0;
			Item.shoot = 1;
			Item.value = 12000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item8;
			Item.shoot = 1;
			Item.shootSpeed = 0;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rain Staff");
			// Tooltip.SetDefault("Allows you to call and revoke precipitation");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (Main.raining)
				Main.raining = false;

			else
			{
				Main.rainTime = (int)Helper.DistortFloat(RainTimeInMinuts * 60 * 60, DistortPercent);
				Main.raining = true;
				Main.maxRaining *= 2;
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddIngredient(ItemID.RainCloud, 9);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.MagicWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
