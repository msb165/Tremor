using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Souls
{
	public class SorcererSoul:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 22;
			Item.rare = 3;
			Item.accessory = true;
			Item.value = 100000;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sorcerer Soul");
			/* Tooltip.SetDefault("10% increased magic damage\n" +
"Increases magic critical strike chance by 15\n" +
"Increases maximum mana by 60"); */
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 6));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statManaMax2 += 60;
			player.GetDamage(DamageClass.Magic) += 0.1f;
			player.GetCritChance(DamageClass.Magic) += 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SorcererFocus>());
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 3);
			recipe.AddIngredient(ItemID.SorcererEmblem, 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AltarofEnchantmentsTile>());
			recipe.AddRecipe();
		}
	}
}
