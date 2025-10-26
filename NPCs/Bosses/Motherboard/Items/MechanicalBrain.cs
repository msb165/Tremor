using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs.Bosses.Motherboard.Items
{
	public class MechanicalBrain:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 18;
			Item.maxStack = 20;

			Item.rare = 5;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = 4;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Mechanical Brain");
			/* Tooltip.SetDefault("Summons the Motherboard\n" +
"Requires hardmode and night time"); */
		}

		public override bool CanUseItem(Player player)
		{
			return Main.hardMode && !Main.dayTime && !NPC.AnyNPCs(ModContent.NPCType<Bosses.Motherboard.Motherboard>());
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<Bosses.Motherboard.Motherboard>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}

		public override void AddRecipes()
		{
			var recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Vertebrae, 6);
			recipe.AddRecipeGroup(RecipeGroupID.IronBar, 6);
			recipe.AddIngredient(ItemID.SoulofNight, 6);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}
