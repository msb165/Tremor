using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SolarBand:TremorModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Carrot);

			item.rare = 11;
			item.value = 380000;
			item.useTime = 25;
			item.useAnimation = 25;

			item.shoot = ModContent.ProjectileType<Projectiles.SolarMeteor>();
			item.buffType = ModContent.BuffType<Buffs.SolarMeteorBuff>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Band");
			Tooltip.SetDefault("Summons a solar meteor");
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<UnchargedBand>());
			recipe.AddIngredient(3458, 10);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
