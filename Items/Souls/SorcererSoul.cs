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

			item.width = 22;
			item.height = 22;
			item.rare = 3;
			item.accessory = true;
			item.value = 100000;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sorcerer Soul");
			Tooltip.SetDefault("10% increased magic damage\n" +
"Increases magic critical strike chance by 15\n" +
"Increases maximum mana by 60");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 6));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statManaMax2 += 60;
			player.GetDamage(DamageClass.Magic) += 0.1f;
			player.GetCritChance(DamageClass.Magic) += 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SorcererFocus>());
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 3);
			recipe.AddIngredient(ItemID.SorcererEmblem, 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AltarofEnchantmentsTile>());
			recipe.AddRecipe();
		}
	}
}
