using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class MoltenHeart:TremorModItem
	{
		const int XOffset = 300;
		const int YOffset = 100;

		public override void SetDefaults()
		{

			Item.width = 40;
			Item.height = 28;
			Item.maxStack = 20;
			Item.value = 100;
			Item.rare = 3;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 4;
			Item.consumable = true;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Molten Heart");
			/* Tooltip.SetDefault("Summons Heater of Worlds\n" +
"Requires the hell biome"); */
		}

		public override bool CanUseItem(Player player)
		{
			return player.position.Y / 16f > Main.maxTilesY - 200 && NPC.downedBoss2 && !NPC.AnyNPCs(ModContent.NPCType<HeaterOfWorldsHead>());
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Hellstone, 25);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddIngredient(ModContent.ItemType<FireFragment>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(26);
			recipe.AddRecipe();
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<HeaterOfWorldsHead>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}
	}
}
