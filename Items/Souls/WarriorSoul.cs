using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Souls
{
	public class WarriorSoul:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 22;

			item.accessory = true;
			item.defense = 4;
			item.rare = 3;
			item.value = 100000;
		}

		public override void SetStaticDefaults()
		{
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 6));
			DisplayName.SetDefault("Warrior Soul");
			Tooltip.SetDefault("10% increased melee damage\n" +
"Increases melee critical strike chance by 15");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Melee) += 0.1f;
			player.GetCritChance(DamageClass.Melee) += 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<WarriorFocus>());
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 3);
			recipe.AddIngredient(ItemID.WarriorEmblem, 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AltarofEnchantmentsTile>());
			recipe.AddRecipe();
		}
	}
}
