using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Diamond
{
	public class DiamondBeam:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.channel = true;
			Item.damage = 288;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 7;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 16;
			Item.useAnimation = 16;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = 13800;
			Item.rare = 4;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = false;
			Item.staff[Item.type] = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.DiamondBeamPro>();
			Item.shootSpeed = 15f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Diamond Beam");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<RuneBar>(), 12);
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 15);
			recipe.AddIngredient(ItemID.Diamond, 10);
			recipe.AddIngredient(ModContent.ItemType<LapisLazuli>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.DivineForgeTile>());
			recipe.AddRecipe();
		}
	}
}
