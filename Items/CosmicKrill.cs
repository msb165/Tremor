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
			item.width = 26;
			item.height = 28;
			item.maxStack = 20;
			item.value = 100;
			item.rare = 11;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 4;
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmic Krill");
			Tooltip.SetDefault("Summons the Space Whale\n" +
"Requires Tremode");
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
