using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Doom;

namespace Tremor.Items
{
	public class Voltager:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 212;
			Item.DamageType = DamageClass.Magic;
			Item.width = 28;
			Item.height = 30;
			Item.useTime = 30;
			Item.useAnimation = 14;
			Item.shoot = ModContent.ProjectileType<Projectiles.LightningBoltPro>();
			Item.shootSpeed = 7f;
			Item.mana = 6;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 122355;
			Item.rare = 5;
			Item.UseSound = SoundID.Item117;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Voltager");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 10);
			recipe.AddIngredient(3467, 10);
			recipe.AddIngredient(ModContent.ItemType<Doomstone>(), 9);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 12);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 8);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
