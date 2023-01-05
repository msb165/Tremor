using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Souls
{
	public class BottledSoulOfNight:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 28;
			item.maxStack = 1;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;

			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.rare = 5;
			item.createTile = ModContent.TileType<Tiles.BottledSoulOfNight>();
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottled Soul of Night");
			Tooltip.SetDefault("15% increased melee speed if worn\n" +
"8% increased melee speed if placed");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(521, 5);
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.GetAttackSpeed(DamageClass.Melee) += 0.15f;
		}
	}
}
