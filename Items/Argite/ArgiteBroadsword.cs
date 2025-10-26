using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Argite
{
	public class ArgiteBroadsword:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 22;
			Item.DamageType = DamageClass.Melee;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 12;
			Item.value = 20000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Argite Broadsword");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ArgiteBar>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 61);
			}
		}
	}
}
