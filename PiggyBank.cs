using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor
{
	public class PiggyBank : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)//Add support for defender coins in bank3?
		{
			Chest bank = item.type switch
			{
				ItemID.PiggyBank or ItemID.MoneyTrough => Main.LocalPlayer.bank,
				ItemID.Safe => Main.LocalPlayer.bank2,
				ItemID.DefendersForge => Main.LocalPlayer.bank3,
				ItemID.VoidVault => Main.LocalPlayer.bank4,
				_ => null
			};

			if(bank == null){return;}

			var coins = Utils.CoinsSplit(Utils.CoinsCount(out _, bank.item));
			List<string> coinTexts = new List<string>(coins.Length);
			for (int i=0; i<3; i++)
			{
				if (coins[i] > 0)
				{
					coinTexts.Add($"{coins[i]} [i/s1:{ItemID.PlatinumCoin - i}]");
				}
			}

			if(coinTexts.Count>0)
			{
				tooltips.Add(new TooltipLine(Mod, "", string.Join(" ",coinTexts)));
			}
		}
	}
}
