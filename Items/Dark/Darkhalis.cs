using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Doom;

namespace Tremor.Items.Dark
{
	public class Darkhalis:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Arkhalis);

			Item.damage = 90;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Darkhalis");
			// Tooltip.SetDefault("'It came from the deep abyss...'");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ModContent.ProjectileType<Projectiles.DarkhalisPro>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Arkhalis, 1);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 22);
			recipe.AddIngredient(ModContent.ItemType<Doomstone>(), 15);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
