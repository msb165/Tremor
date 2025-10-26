using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Tremor.Items.Cursed
{
	public class CursedCauldron:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;
			Item.value = 100000;
			Item.rare = 5;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cursed Cauldron");
			/* Tooltip.SetDefault("15% increased alchemical damage\n" +
"20% increased alchemical critical strike chance\n" +
"Alchemic damage confuses enemies"); */
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(8, 4));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.15f;
			player.AddBuff(ModContent.BuffType<Buffs.CursedCloudBuff>(), 2);
			player.GetModPlayer<MPlayer>().alchemicalCrit += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BlackCauldron>(), 1);
			recipe.AddIngredient(ModContent.ItemType<DeathFormula>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}
	}
}
