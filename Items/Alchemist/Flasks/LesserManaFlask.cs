using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Projectiles.Alchemic;

namespace Tremor.Items.Alchemist.Flasks
{
	public class LesserManaFlask : AlchemistItem
	{

		public override void SetDefaults()
		{
			item.crit = 4;
			item.damage = 11;
			//item.DamageType = DamageClass.Throwing;
			item.width = 26;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.consumable = true;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.shoot = ModContent.ProjectileType<Projectiles.Alchemic.LesserManaFlaskPro>();
			item.shootSpeed = 8f;
			item.useStyle = 1;
			item.knockBack = 1;
			item.UseSound = SoundID.Item106;
			item.value = 70;
			item.rare = 1;
			item.autoReuse = false;

			item.ammo = ModContent.ItemType<BoomFlask>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lesser Mana Flask");
			Tooltip.SetDefault("Throws a flask that explodes into clouds\n" +
"Clouds deal damage to enemies and restore mana");
		}

		public override void PickAmmo(Item weapon, Player player, ref int type, ref float speed, ref StatModifier damage, ref float knockback)
		{
			type = ModContent.ProjectileType<ManaCloudPro>();
		}

		public override void UpdateInventory(Player player)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			if (modPlayer.novaHelmet)
			{
				item.autoReuse = true;
			}
			if (!modPlayer.novaHelmet)
			{
				item.autoReuse = false;
			}

			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) != -1)
			{
				item.shootSpeed = 11f;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) < 1)
			{
				item.shootSpeed = 8f;
			}
			if (modPlayer.core)
			{
				item.autoReuse = true;
			}
			if (!modPlayer.core)
			{
				item.autoReuse = false;
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.AddIngredient(ModContent.ItemType<ManaFruit>(), 1);
			recipe.AddIngredient(ModContent.ItemType<GelCube>(), 1);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}

	}
}
