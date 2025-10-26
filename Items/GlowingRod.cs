using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GlowingRod:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 20;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 11;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 18;
			Item.useAnimation = 18;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = 13800;
			Item.rare = 4;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = false;
			Item.staff[Item.type] = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.ZootalooRodPro>();
			Item.shootSpeed = 15f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glowing Rod");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.AmethystStaff, 1);
			recipe.AddIngredient(ModContent.ItemType<LightBulb>(), 8);
			recipe.AddIngredient(ModContent.ItemType<RockHorn>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TopazStaff, 1);
			recipe.AddIngredient(ModContent.ItemType<LightBulb>(), 8);
			recipe.AddIngredient(ModContent.ItemType<RockHorn>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SapphireStaff, 1);
			recipe.AddIngredient(ModContent.ItemType<LightBulb>(), 8);
			recipe.AddIngredient(ModContent.ItemType<RockHorn>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.EmeraldStaff, 1);
			recipe.AddIngredient(ModContent.ItemType<LightBulb>(), 8);
			recipe.AddIngredient(ModContent.ItemType<RockHorn>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.DiamondStaff, 1);
			recipe.AddIngredient(ModContent.ItemType<LightBulb>(), 8);
			recipe.AddIngredient(ModContent.ItemType<RockHorn>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.RubyStaff, 1);
			recipe.AddIngredient(ModContent.ItemType<LightBulb>(), 8);
			recipe.AddIngredient(ModContent.ItemType<RockHorn>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

		}
	}
}
