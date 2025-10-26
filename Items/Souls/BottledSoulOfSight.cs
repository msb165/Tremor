using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Souls
{
	public class BottledSoulOfSight:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 26;
			Item.maxStack = 1;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;

			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 150;
			Item.rare = 5;
			Item.createTile = ModContent.TileType<Tiles.BottledSoulOfSight>();
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bottled Soul of Sight");
			/* Tooltip.SetDefault("Makes you shine if worn\n" +
"Shows the location of enemies if placed"); */
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(549, 5);
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.GetCritChance(DamageClass.Generic) += 6;
		}
	}
}
