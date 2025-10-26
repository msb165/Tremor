using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class PhantomJavelin:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.value = 100000;
			Item.useStyle = 1;
			Item.useAnimation = 25;
			Item.useTime = 25;
			Item.autoReuse = true;
			Item.rare = 3;
			Item.width = 42;
			Item.height = 42;
			Item.UseSound = SoundID.Item8;
			Item.damage = 28;
			Item.knockBack = 4;
			Item.mana = 7;
			Item.shoot = ModContent.ProjectileType<Projectiles.PhantomSpear>();
			Item.shootSpeed = 14f;
			Item.noMelee = true; //So that the swing itself doesn't do damage; this weapon is projectile-only
			Item.noUseGraphic = true; //No swing animation
			Item.DamageType = DamageClass.Magic;
			Item.crit = 7;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Phantom Javelin");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.MagicWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
