using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ShadowTooth:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 42;
			Item.height = 46;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = 121;
			Item.shootSpeed = 6f;
			Item.useStyle = 1;
			Item.knockBack = 2;
			Item.value = 46000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shadow Tooth");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SoulofNight, 8);
			recipe.AddIngredient(ItemID.SoulofSight, 8);
			recipe.AddIngredient(ModContent.ItemType<ColdTooth>(), 1);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SoulofNight, 8);
			recipe.AddIngredient(ItemID.SoulofSight, 8);
			recipe.AddIngredient(ModContent.ItemType<FlamingTooth>(), 1);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(153, 120);
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool())
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 65);
			}
		}
	}
}
