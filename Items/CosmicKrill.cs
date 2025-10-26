using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class CosmicKrill:TremorModItem
	{
		const int XOffset = -400;
		const int YOffset = -400;

		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 28;
			Item.maxStack = 20;
			Item.value = 100;
			Item.rare = 11;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 4;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cosmic Krill");
			/* Tooltip.SetDefault("Summons the Space Whale\n" +
"Requires Tremode"); */
		}

		public override bool CanUseItem(Player player)
		{
			return NPC.downedMoonlord && !NPC.AnyNPCs(ModContent.NPCType<SpaceWhale>());
		}

		public override bool? UseItem(Player player)
		{
			Main.NewText("Space Whale has awoken!", 175, 75, 255);
			Terraria.Audio.SoundEngine.PlaySound(SoundID.SoundByIndex[15], player.position);//Variant 0
			if (Main.netMode != 1)
			{
				NPC.NewNPC(null, (int)player.Center.X + XOffset, (int)player.Center.Y + YOffset, ModContent.NPCType<SpaceWhale>());
			}
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Shrimp, 1);
			recipe.AddIngredient(ModContent.ItemType<StarBar>(), 16);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 16);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.AddRecipe();
		}
	}
}
