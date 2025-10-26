using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class Obscuritron:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.autoReuse = true;

			Item.useStyle = 1;
			Item.useAnimation = 25;
			Item.useTime = 25;
			Item.knockBack = 5.5f;
			Item.width = 40;
			Item.height = 40;
			Item.damage = 260;
			Item.scale = 1.15f;
			Item.UseSound = SoundID.Item1;
			Item.rare = 11;
			Item.value = 430000;
			Item.DamageType = DamageClass.Melee;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Obscuritron");
			// Tooltip.SetDefault("");
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Dusts.NightmareFlame>());
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 30);
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 15);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 20);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 25);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
