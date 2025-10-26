using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Cursed
{
	public class CursedTwister:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 82;
			Item.DamageType = DamageClass.Magic;
			Item.width = 28;
			Item.height = 30;
			Item.useTime = 14;
			Item.useAnimation = 14;
			Item.shoot = ModContent.ProjectileType<Projectiles.CursedTwisterPro>();
			Item.shootSpeed = 14f;
			Item.mana = 6;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 122355;
			Item.rare = 5;
			Item.UseSound = SoundID.Item21;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cursed Twister");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.CursedFlames, 1);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 10);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 8);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
