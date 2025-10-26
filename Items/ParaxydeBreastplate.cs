using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class ParaxydeBreastplate:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 10000;
			Item.rare = 5;
			Item.defense = 22;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paraxyde Breastplate");
			// Tooltip.SetDefault("Increases melee and magic criticals strike chance by 15");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Magic) += 15;
			player.GetCritChance(DamageClass.Melee) += 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ParaxydeShard>(), 18);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AlchematorTile>());
			recipe.AddRecipe();
		}
	}
}
