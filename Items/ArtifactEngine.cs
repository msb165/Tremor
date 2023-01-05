using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs.Bosses.CogLord;

namespace Tremor.Items
{
	public class ArtifactEngine:TremorModItem
	{
		const int XOffset = -400;
		const int YOffset = -400;

		public override void SetDefaults()
		{

			item.width = 40;
			item.height = 28;
			item.maxStack = 20;
			item.value = 100;
			item.rare = 5;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 4;
			item.consumable = true;

		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Artifact Engine");
			Tooltip.SetDefault("Summons Cog Lord\n" +
"Requires any mech. boss to have been slain, hardmode and night time");
		}

		public override bool CanUseItem(Player player)
		{
			return !Main.dayTime && Main.hardMode && NPC.downedMechBossAny && !NPC.AnyNPCs(ModContent.NPCType<CogLord>());
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(575, 30);
			recipe.AddIngredient(ItemID.HallowedBar, 6);
			recipe.AddIngredient(ItemID.Cog, 25);
			recipe.AddIngredient(ItemID.Wire, 20);
			recipe.AddIngredient(ModContent.ItemType<GolemCore>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}

		public override bool? UseItem(Player player)
		{
			Main.NewText("Cog Lord has awoken!", 175, 75, 255);
			Terraria.Audio.SoundEngine.PlaySound(SoundID.SoundByIndex[15], player.position);//Variant 0
			if (Main.netMode != 1)
			{
				NPC.NewNPC(null, (int)player.Center.X + XOffset, (int)player.Center.Y + YOffset, ModContent.NPCType<CogLord>());
			}
			return true;
		}
	}
}
