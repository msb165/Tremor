using Terraria;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class GlacierWoodHelmet:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 26;
			Item.value = 400;
			Item.rare = 1;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glacier Wood Helmet");
			// Tooltip.SetDefault("");
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<GlacierWoodChestplate>() && legs.type == ModContent.ItemType<GlacierWoodLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "1 defense";
			player.statDefense += 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 20);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
