using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BlueSakura:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 7;
			Item.DamageType = DamageClass.Summon;
			Item.mana = 12;
			Item.width = 30;
			Item.height = 28;

			Item.useTime = 36;
			Item.useAnimation = 36;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = Item.buyPrice(0, 0, 1, 0);
			Item.rare = 1;
			Item.UseSound = SoundID.Item44;
			Item.shoot = ModContent.ProjectileType<Projectiles.Minions.BlueSakuraPro>();
			Item.shootSpeed = 1f;
			Item.buffType = ModContent.BuffType<Buffs.BlueSakuraBuff>();
			Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Blue Sakura");
			// Tooltip.SetDefault("Summons a blue wind to fight for you.");
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse != 2;
		}

		public override bool? UseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim(false);
			}
			return base.UseItem(player);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
