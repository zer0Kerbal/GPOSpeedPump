﻿/*
	This file is part of Goodspeed Automatic Fuel Pump /L Unleashed
		© 2021 Lisias T : http://lisias.net <support@lisias.net>
		© 2016-2019 hab136
		© 2015 Geordiepigeonowner
		© 2014 Gaius Goodspeed

	Goodspeed Automatic Fuel Pump /L Unleashed is licensed as follows:
		* GPL 3.0 : https://www.gnu.org/licenses/gpl-3.0.txt

	Goodspeed Automatic Fuel Pump /L Unleashed is distributed in the
	hope that it will be useful, but WITHOUT ANY WARRANTY; without even
	the implied warranty of	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the GNU General Public License 3.0 along
	with Goodspeed Automatic Fuel Pump /L Unleashed.
	If not, see <https://www.gnu.org/licenses/>.

*/
using System.Collections.Generic;

namespace GPOSpeedFuelPump
{
	public static class ModuleManagerSupport
	{
		public static IEnumerable<string> ModuleManagerAddToModList()
		{
			string[] r = { typeof(Version).Namespace };
			return r;
		}
	}
}