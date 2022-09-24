namespace Ude.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class EUCJPContextAnalyser : JapaneseContextAnalyser
    {
        private const byte HIRAGANA_FIRST_BYTE = 164;

        protected override int GetOrder( byte[] buf, int offset, out int charLen )
        {
            byte b = buf[ offset ];
            switch ( b )
            {
                case 142:
                case 161:
                case 162:
                case 163:
                case 164:
                case 165:
                case 166:
                case 167:
                case 168:
                case 169:
                case 170:
                case 171:
                case 172:
                case 173:
                case 174:
                case 175:
                case 176:
                case 177:
                case 178:
                case 179:
                case 180:
                case 181:
                case 182:
                case 183:
                case 184:
                case 185:
                case 186:
                case 187:
                case 188:
                case 189:
                case 190:
                case 191:
                case 192:
                case 193:
                case 194:
                case 195:
                case 196:
                case 197:
                case 198:
                case 199:
                case 200:
                case 201:
                case 202:
                case 203:
                case 204:
                case 205:
                case 206:
                case 207:
                case 208:
                case 209:
                case 210:
                case 211:
                case 212:
                case 213:
                case 214:
                case 215:
                case 216:
                case 217:
                case 218:
                case 219:
                case 220:
                case 221:
                case 222:
                case 223:
                case 224:
                case 225:
                case 226:
                case 227:
                case 228:
                case 229:
                case 230:
                case 231:
                case 232:
                case 233:
                case 234:
                case 235:
                case 236:
                case 237:
                case 238:
                case 239:
                case 240:
                case 241:
                case 242:
                case 243:
                case 244:
                case 245:
                case 246:
                case 247:
                case 248:
                case 249:
                case 250:
                case 251:
                case 252:
                case 253:
                case 254:
                    charLen = 2;
                    break;
                default:
                    if ( b == 191 )
                    {
                        charLen = 3;
                    }
                    else
                    {
                        charLen = 1;
                    }
                    break;
            }
            checked
            {
                if ( b == 164 )
                {
                    byte b2 = buf[ offset + 1 ];
                    if ( b2 >= 161 && b2 <= 243 )
                    {
                        return unchecked((int) b2) - 161;
                    }
                }
                return -1;
            }
        }
        protected override int GetOrder( byte[] buf, int offset )
        {
            checked
            {
                if ( buf[ offset ] == 164 )
                {
                    byte b = buf[ offset + 1 ];
                    if ( b >= 161 && b <= 243 )
                    {
                        return unchecked((int) b) - 161;
                    }
                }
                return -1;
            }
        }
    }
}