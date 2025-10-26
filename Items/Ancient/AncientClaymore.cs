using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Ancient
{
	public class AncientClaymore:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 110;
			Item.DamageType = DamageClass.Melee;
			Item.width = 88;
			Item.height = 88;
			Item.useTime = 45;
			Item.useAnimation = 45;
			Item.useStyle = 1;
			Item.shoot = ModContent.ProjectileType<Projectiles.AncientClaymorePro>();
			Item.shootSpeed = 10f;
			Item.knockBack = 4;
			Item.value = 250000;
			Item.rare = 10;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = false;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ancient Claymore");
			// Tooltip.SetDefault("Shoots out a ghostly sword that inflicts Ichor on enemies");
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 64);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AncientTablet>(), 14);
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
