using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class OmnikronBreastplate:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 18;
			item.height = 18;
			item.value = 0;

			item.rare = 0;
			item.defense = 40;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Omnikron Breastplate");
			Tooltip.SetDefault("20% increased damage");
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips[0].OverrideColor = new Color(238, 194, 73);
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.2f;
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<OmnikronBar>(), 26);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
