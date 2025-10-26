using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Brass;

namespace Tremor.Items
{
	public class HealthStimPack:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.Size = new Vector2(36);
			Item.maxStack = 999;
			Item.rare = 11;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 2;
			Item.UseSound = SoundID.Item3;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Health Stim Pack");
			/* Tooltip.SetDefault("Restores 50 health\n" +
"Has no cooldown"); */
		}

		public override bool ConsumeItem(Player player) => true;

		public override bool? UseItem(Player player)
		{
			if (player.whoAmI == Main.myPlayer)
			{
				SoundEngine.PlaySound(SoundID.Item3, player.position);
				player.HealEffect(50);
				player.statLife = Math.Min(player.statLifeMax2, player.statLife + 50);
				return true;
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BrassBar>(), 2);
			recipe.AddIngredient(ItemID.SuperHealingPotion);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 5);
			recipe.SetResult(this);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}

	}
}