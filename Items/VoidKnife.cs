using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;

namespace Tremor.Items
{
	public class VoidKnife:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 666;
			Item.DamageType = DamageClass.Melee;
			Item.width = 56;
			Item.height = 56;
			Item.useTime = 21;
			Item.useAnimation = 21;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 120000;
			Item.rare = 10;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
			Item.scale = 1.5f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Void Knife");
			/* Tooltip.SetDefault("Hitting enemies will spawn an explosion\n" +
"If you are below 50% of life your hits have a chance to heal you"); */
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			Projectile.NewProjectile(null, target.Center.X, target.Center.Y, 0f, 0f, ModContent.ProjectileType<Projectiles.VoidKnifeExplosion>(), Item.damage, Item.knockBack, Main.myPlayer);
			if (player.statLife < (player.statLifeMax2 * 0.5f) && Main.rand.NextBool(4))
			{
				int NewLife = Main.rand.Next(19, 41);
				player.statLife += NewLife;
				player.HealEffect(NewLife);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<DarkMatter>(), 64);
			recipe.AddIngredient(ModContent.ItemType<AtisBlood>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}

	}
}
