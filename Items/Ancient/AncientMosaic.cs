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

			item.width = 30;
			item.height = 30;
			item.maxStack = 1;

			item.rare = 4;
			item.maxStack = 20;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Mosaic");
			Tooltip.SetDefault("Summons the Alchemaster\n" +
"Requires hardmode and night time");
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
			ModRecipe recipe = new ModRecipe(mod);
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
