using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs.Bosses.NovaPillar.Items;

namespace Tremor.Items
{
	public class NovaBand:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Carrot);

			Item.rare = 11;
			Item.value = 380000;
			Item.useTime = 25;
			Item.useAnimation = 25;

			Item.shoot = ModContent.ProjectileType<Projectiles.Warkee>();
			Item.buffType = ModContent.BuffType<Buffs.WarkeeBuff>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nova Band");
			// Tooltip.SetDefault("Summons a warkee");
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(Item.buffType, 3600, true);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<UnchargedBand>());
			recipe.AddIngredient(ModContent.ItemType<NovaFragment>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
