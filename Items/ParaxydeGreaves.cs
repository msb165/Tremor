using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class ParaxydeGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 10000;
			Item.rare = 5;
			Item.defense = 17;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paraxyde Greaves");
			// Tooltip.SetDefault("Increases maximum mana by 40");
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ParaxydeShard>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AlchematorTile>());
			recipe.AddRecipe();
		}

	}
}
