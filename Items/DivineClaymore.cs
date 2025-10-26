using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Angelite;
using Tremor.Items.Doom;

namespace Tremor.Items
{
	public class DivineClaymore:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 232;
			Item.DamageType = DamageClass.Melee;
			Item.width = 46;
			Item.height = 48;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.shoot = ModContent.ProjectileType<Projectiles.DivineClaymorePro>();
			Item.shootSpeed = 12f;
			Item.value = 12400;
			Item.rare = 0;
			Item.UseSound = SoundID.Item15;
			Item.autoReuse = true;
			Item.useTurn = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Divine Claymore");
			// Tooltip.SetDefault("");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<VoidBlade>(), 1);
			recipe.AddIngredient(ModContent.ItemType<AngeliteBar>(), 30);
			recipe.AddIngredient(ModContent.ItemType<Aquamarine>(), 8);
			recipe.AddIngredient(ModContent.ItemType<AngryShard>(), 3);
			recipe.AddIngredient(ModContent.ItemType<Doomstone>(), 3);
			recipe.AddIngredient(ItemID.SoulofLight, 25);
			recipe.AddIngredient(ModContent.ItemType<PurpleQuartz>(), 5);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.DivineForgeTile>());
			recipe.AddRecipe();
		}
	}
}
