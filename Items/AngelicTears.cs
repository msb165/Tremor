using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Angelite;

namespace Tremor.Items
{
	public class AngelicTears:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 256;
			Item.DamageType = DamageClass.Magic;
			Item.width = 28;
			Item.height = 30;
			Item.useTime = 14;
			Item.useAnimation = 14;
			Item.shoot = ModContent.ProjectileType<Projectiles.AngelTearsPro>();
			Item.shootSpeed = 16f;
			Item.mana = 6;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 90000;
			Item.rare = 0;
			Item.UseSound = SoundID.Item21;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Angelic Tears");
			// Tooltip.SetDefault("");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AngeliteBar>(), 12);
			recipe.AddIngredient(ModContent.ItemType<LapisLazuli>(), 7);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ModContent.ItemType<HuskofDusk>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
