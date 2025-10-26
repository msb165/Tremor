using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TrueBloodCarnage:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 92;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 52;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.shoot = ModContent.ProjectileType<Projectiles.TrueBloodCarnage>();
			Item.shootSpeed = 10f;
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("True Blood Carnage");
			// Tooltip.SetDefault("");
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 60);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BloodCarnage>(), 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
