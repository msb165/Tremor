using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items.Ancient
{
	public class AncientMosaic:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 30;
			Item.maxStack = 1;

			Item.rare = 4;
			Item.maxStack = 20;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = 4;
			Item.UseSound = SoundID.Item44;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ancient Mosaic");
			/* Tooltip.SetDefault("Summons the Alchemaster\n" +
"Requires hardmode and night time"); */
		}

		public override bool CanUseItem(Player player)
		{
			return !Main.dayTime && Main.hardMode && !NPC.AnyNPCs(ModContent.NPCType<Alchemaster>());
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<Alchemaster>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<RedPuzzleFragment>(), 1);
			recipe.AddIngredient(ModContent.ItemType<GreenPuzzleFragment>(), 1);
			recipe.AddIngredient(ModContent.ItemType<YellowPuzzleFragment>(), 1);
			recipe.AddIngredient(ModContent.ItemType<PurplePuzzleFragment>(), 1);
			recipe.AddIngredient(ModContent.ItemType<BottledGlue>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(26);
			recipe.AddRecipe();
		}

	}
}
