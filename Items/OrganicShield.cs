using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Dark;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class OrganicShield:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 26;
			item.height = 26;

			item.value = 12600;
			item.rare = 8;
			item.accessory = true;
			item.defense = 12;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Organic Shield");
			Tooltip.SetDefault("Gives health when in Corruption and Crimson");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed -= 0.30f;
			player.aggro += 300;
			if (player.ZoneCorrupt || player.ZoneCrimson)
			{
				player.statLifeMax2 += 100;
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<MeatShield>(), 1);
			recipe.AddIngredient(ModContent.ItemType<DarkAbsorber>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<MeatShield>(), 1);
			recipe.AddIngredient(ModContent.ItemType<PatronoftheMind>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}
	}
}
