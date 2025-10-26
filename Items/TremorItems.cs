using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TremorItems : GlobalItem
	{

		public override void UpdateEquip(Item item, Player player)
		{
			//items damage
			if (item.type == 1865)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
			if (item.type == 3110)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
			if (item.type == 899)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
			if (item.type == 900)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
			if (item.type == 935)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.12f;
			}
			if (item.type == 1301)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
			}
			if (item.type == 552)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.07f;
			}
			if (item.type == 1208)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.03f;
			}
			if (item.type == 1209)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.02f;
			}
			if (item.type == 379)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.05f;
			}
			if (item.type == 403)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.06f;
			}
			if (item.type == 1218)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.04f;
			}
			if (item.type == 1219)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.03f;
			}
			if (item.type == 1004)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.05f;
			}
			//items crit chance
			if (item.type == 374)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 3;
			}
			if (item.type == 1208)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 2;
			}
			if (item.type == 1209)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 1;
			}
			if (item.type == 380)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 5;
			}
			if (item.type == 1213)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 6;
			}
			if (item.type == 404)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 4;
			}
			if (item.type == 1218)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 3;
			}
			if (item.type == 1219)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 3;
			}
			if (item.type == 3808)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 10;
			}
			if (item.type == 551)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 7;
			}
			if (item.type == 1004)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 7;
			}
			if (item.type == 1317)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 8;
			}
			if (item.type == 3873)
			{
				player.GetModPlayer<MPlayer>().alchemicalCrit += 30;
			}
		}

		public override void SetDefaults(Item item)
		{
			/* WRONG -- TODO: Remove this buff or actually code it correctly
			if (Item.ranged && Main.LocalPlayer.active && Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<Buffs.ShotSpeedBuff>()) != -1)
			{
				Item.shootSpeed *= 2f;
			}
			if (Item.ranged && Main.LocalPlayer.active && Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<Buffs.ShotSpeedBuff>()) != -1)
			{
				Item.shootSpeed *= 2f;
			}
			*/
			if (item.type == 2196)
			{
				item.value = 30;
			}
			if (item.type == ItemID.Minishark)
			{
				item.value = 500000;
			}
			if (item.type == 3)
			{

			}
			/* WRONG -- TODO: Remove this buff or actually code it correctly
			if (item.type == ItemID.EnchantedSword && Main.LocalPlayer.active && Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<Buffs.EnchantedBuff>()) != -1)
			{
				Item.damage += 5;
			}
			if (item.type == ItemID.EnchantedBoomerang && Main.LocalPlayer.active && Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<Buffs.EnchantedBuff>()) != -1)
			{
				Item.damage += 5;
			}
			*/
			if (item.type == ItemID.SlimeStaff)
			{
				item.value = 2000;
			}
		}
	}
}