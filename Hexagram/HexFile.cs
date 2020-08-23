/* ----------------------------------------------------------------------------
Hexagram : a hexadecimal file editor
Copyright (C) 1998-2020  George E Greaney

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
----------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Hexagram
{
    class HexFile
    {
        Byte[] hexbuf;
        uint hexlen;

        public HexFile(String se1name)
        {
            
            hexbuf = File.ReadAllBytes(se1name);
            hexlen = (uint) hexbuf.Length;
        }

        public String getHexData()
        {

            StringBuilder info = new StringBuilder();
            StringBuilder ascii = new StringBuilder();
            int i = 0;
            uint loc = 0;
            for (; i < hexbuf.Length; )
            {
                if (i % 16 == 0)
                {
                    info.Append(loc.ToString("X8") + ": ");
                }
                uint b = hexbuf[i];
                info.Append(b.ToString("X2"));
                info.Append(" ");
                ascii.Append((b >= 0x20 && b <= 0x7E) ? ((char)b).ToString() : ".");
                i++;
                loc++;
                if (i % 16 == 0)
                {
                    info.AppendLine(ascii.ToString());
                    ascii.Clear();
                }
            }
            if (i % 16 != 0)
            {
                int remainder = (i % 16);
                for (; remainder < 16; remainder++)
                {
                    info.Append("   ");

                }
                info.AppendLine(ascii.ToString());
            }
            return info.ToString();
        }
    }
}
