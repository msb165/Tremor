using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Sparks;

namespace Tremor.Items
{
	public class SorcererFocus:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 22;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
			item.value = 50000;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sorcerer Focus");
			Tooltip.SetDefault("6% increased magic damage\n" +
"Increases magic critical strike chance by 12\n" +
"Increases maximum mana by 40");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 4));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statManaMax2 += 40;
			player.GetDamage(DamageClass.Magic) += 0.06f;
			player.GetCritChance(DamageClass.Magic) += 12;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SorcererSpark>());
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 1);
			recipe.AddIngredient(ItemID.Sapphire, 16);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AltarofEnchantmentsTile>());
			recipe.AddRecipe();
		}
	}
}
