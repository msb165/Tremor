using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ParaxydeCleaver:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 66;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 60;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 216000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = 522;
			Item.shootSpeed = 23f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paraxyde Cleaver");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ParaxydeShard>(), 15);
			recipe.AddIngredient(426, 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AlchematorTile>());
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(2))
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 27);
			}
		}
	}
}
