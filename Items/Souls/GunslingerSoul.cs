using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Souls
{
	public class GunslingerSoul:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 22;

			item.rare = 3;
			item.accessory = true;
			item.value = 100000;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gunslinger Soul");
			Tooltip.SetDefault("10% increased ranged damage\n" +
"Increases ranged critical strike chance by 15");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 6));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Ranged) += 0.1f;
			player.GetCritChance(DamageClass.Ranged) += 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<GunslingerFocus>());
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 3);
			recipe.AddIngredient(ItemID.RangerEmblem, 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AltarofEnchantmentsTile>());
			recipe.AddRecipe();
		}
	}
}
