using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Tremor.Items.Souls
{
	public class ThrowerSoul:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 22;

			Item.rare = 3;
			Item.accessory = true;
			Item.value = 50000;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Thrower Soul");
			/* Tooltip.SetDefault("10% increased thrown damage\n" +
"Increases thrown critical strike chance by 15"); */
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 6));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Throwing) += 0.1f;
			player.GetCritChance(DamageClass.Throwing) += 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ThrowerFocus>());
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 3);
			recipe.AddIngredient(ModContent.ItemType<ThrowerEmblem>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AltarofEnchantmentsTile>());
			recipe.AddRecipe();
		}
	}
}
