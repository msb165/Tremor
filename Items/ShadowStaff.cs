using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;

namespace Tremor.Items
{
	public class ShadowStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 34;
			Item.DamageType = DamageClass.Summon;
			Item.mana = 15;
			Item.width = 26;
			Item.height = 28;

			Item.useTime = 36;
			Item.channel = true;
			Item.useAnimation = 36;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = Item.buyPrice(0, 9, 0, 0);
			Item.rare = 7;
			Item.UseSound = SoundID.Item44;
			Item.shoot = ModContent.ProjectileType<Projectiles.Minions.ShadowStaffPro>();
			Item.shootSpeed = 2f;
			Item.buffType = ModContent.BuffType<Buffs.ShadowArmBuff>();
			Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shadow Staff");
			// Tooltip.SetDefault("Summons a shadow arm to fight for you.");
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
			recipe.AddIngredient(ItemID.SoulofNight, 8);
			recipe.AddIngredient(ItemID.SpookyWood, 15);
			recipe.AddIngredient(ModContent.ItemType<DarknessCloth>(), 9);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
