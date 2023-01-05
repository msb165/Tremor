using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class TrueHeroShirt:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 26;
			item.height = 18;

			item.value = 25000;
			item.rare = 0;
			item.defense = 25;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Hero Shirt");
			Tooltip.SetDefault("Gives one of three true blades");
		}

		public override void UpdateEquip(Player player)
		{
			player.AddBuff(ModContent.BuffType<Buffs.SecondTrueBlade>(), 2);
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(248, 1);
			recipe.AddIngredient(ModContent.ItemType<GiantShell>(), 1);
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroArmorplate>(), 1);
			recipe.AddIngredient(ModContent.ItemType<TrueEssense>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
