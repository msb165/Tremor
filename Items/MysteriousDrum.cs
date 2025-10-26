using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class MysteriousDrum:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 32;
			Item.maxStack = 20;
			Item.useTurn = true;
			Item.autoReuse = false;
			Item.useAnimation = 18;
			Item.useTime = 18;
			Item.useStyle = 4;
			Item.consumable = true;
			Item.value = 150;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Mysterious Drum");
			/* Tooltip.SetDefault("Summons Tiki Totem\n" +
"Requires the jungle biome and night time"); */
		}

		public override bool CanUseItem(Player player)
		{
			return !Main.dayTime && player.ZoneJungle && !NPC.AnyNPCs(ModContent.NPCType<TikiTotem>());
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<TikiTotem>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.RichMahogany, 45);
			recipe.AddIngredient(ItemID.Stinger, 2);
			recipe.AddIngredient(ItemID.Rope, 25);
			recipe.AddIngredient(ItemID.ShadowScale, 8);
			recipe.AddIngredient(ItemID.Silk, 6);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.RichMahogany, 45);
			recipe.AddIngredient(ItemID.Stinger, 2);
			recipe.AddIngredient(ItemID.Rope, 25);
			recipe.AddIngredient(ItemID.TissueSample, 8);
			recipe.AddIngredient(ItemID.Silk, 6);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
