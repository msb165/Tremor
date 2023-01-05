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

			item.damage = 232;
			item.DamageType = DamageClass.Melee;
			item.width = 46;
			item.height = 48;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 3;
			item.shoot = ModContent.ProjectileType<Projectiles.DivineClaymorePro>();
			item.shootSpeed = 12f;
			item.value = 12400;
			item.rare = 0;
			item.UseSound = SoundID.Item15;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Divine Claymore");
			Tooltip.SetDefault("");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
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
