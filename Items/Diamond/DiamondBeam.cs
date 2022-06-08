using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Diamond
{
	public class DiamondBeam : ModItem
	{
		public override void SetDefaults()
		{
			item.channel = true;
			item.damage = 288;
			item.magic = true;
			item.mana = 7;
			item.width = 40;
			item.height = 40;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 13800;
			item.rare = 4;
			item.UseSound = SoundID.Item43;
			item.autoReuse = false;
			Item.staff[item.type] = true;
			item.shoot = ModContent.ProjectileType<Projectiles.DiamondBeamPro>();
			item.shootSpeed = 15f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diamond Beam");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
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
