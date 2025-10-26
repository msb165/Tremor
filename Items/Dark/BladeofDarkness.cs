using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Dark
{
	public class BladeofDarkness:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 75;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 52;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.shoot = ModContent.ProjectileType<Projectiles.GloomSphere>();
			Item.shootSpeed = 10f;
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Blade of Darkness");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SoulofNight, 12);
			recipe.AddIngredient(ItemID.Amethyst, 10);
			recipe.AddIngredient(ItemID.BoneSword);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 27);
		}
	}
}
