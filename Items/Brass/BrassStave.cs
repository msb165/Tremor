using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Brass
{
	public class BrassStave:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 80;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 60;
			Item.noMelee = true;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 45;
			Item.useAnimation = 45;
			Item.useStyle = 5;
			Item.value = 12500;
			Item.rare = 5;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = false;
			Item.shoot = 443;
			Item.shootSpeed = 12f;

			Item.staff[Item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brass Stave");
			/* Tooltip.SetDefault("Shoots fast thin bolts\n" +
"Press RMB for powerful attack"); */
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				Item.damage = 80;
				Item.DamageType = DamageClass.Magic;
				Item.mana = 60;
				Item.noMelee = true;
				Item.width = 40;
				Item.height = 40;
				Item.useTime = 45;
				Item.useAnimation = 45;
				Item.useStyle = 5;

				Item.rare = 5;
				Item.UseSound = SoundID.Item43;
				Item.autoReuse = false;
				Item.shoot = 443;
				Item.shootSpeed = 12f;
				//Item.toolTip = "Shoots fast thin bolts";
				//Item.toolTip2 = "Press RMB for powerful attack";
				Item.staff[Item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			}
			else
			{
				Item.damage = 65;
				Item.DamageType = DamageClass.Magic;
				Item.mana = 10;
				Item.noMelee = true;
				Item.width = 40;
				Item.height = 40;
				Item.useTime = 22;
				Item.useAnimation = 22;
				Item.useStyle = 5;

				Item.rare = 5;
				Item.UseSound = SoundID.Item43;
				Item.autoReuse = true;
				Item.shoot = 459;
				Item.shootSpeed = 15f;
				//Item.toolTip = "Shoots fast thin bolts";
				//Item.toolTip2 = "Press RMB for powerful attack";
				Item.staff[Item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			}
			return base.CanUseItem(player);
		}

		public override void UpdateInventory(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				if (player.HasBuffSafe(ModContent.BuffType<Buffs.SteamMageBuff>()))
				{
					Item.damage = 100;
				}
				else
				{
					Item.damage = 80;
				}
			}
			else
			{
				if (player.HasBuffSafe(ModContent.BuffType<Buffs.SteamMageBuff>()))
				{
					Item.damage = 80;
				}
				else
				{
					Item.damage = 65;
				}
			}
		}

	}
}
