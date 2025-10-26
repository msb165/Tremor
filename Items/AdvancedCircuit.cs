using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class AdvancedCircuit:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 38;
			Item.maxStack = 20;

			Item.rare = 7;
			Item.value = 30000;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = 4;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Advanced Circuit");
			/* Tooltip.SetDefault("Summons the Mothership\n" +
"Requires Plantera to have been slain and night time"); */
		}

		public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPCs(ModContent.NPCType<Mothership>()) && NPC.downedPlantBoss && !Main.dayTime;
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<Mothership>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GolemCore>(), 1);
			recipe.AddIngredient(ItemID.HallowedBar, 25);
			recipe.AddIngredient(ItemID.SoulofSight, 12);
			recipe.AddIngredient(ItemID.SoulofMight, 12);
			recipe.AddIngredient(ItemID.SoulofFright, 12);
			recipe.AddIngredient(ItemID.Wire, 30);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GolemCore>(), 1);
			recipe.AddIngredient(ItemID.HallowedBar, 25);
			recipe.AddIngredient(ItemID.SoulofSight, 12);
			recipe.AddIngredient(ModContent.ItemType<SoulofMind>(), 12);
			recipe.AddIngredient(ItemID.SoulofFright, 12);
			recipe.AddIngredient(ItemID.Wire, 30);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
