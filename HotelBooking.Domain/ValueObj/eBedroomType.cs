using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HotelBooking.Domain.ValueObj
{
    /// <summary>
    /// Enum para os tipos de quartos disponíveis
    /// </summary>
    public enum eBedroomType
    {
        [Description( "single" )]
        Single = 1,
        [Description( "standard" )]
        Standard = 2,
        [Description( "luxo" )]
        Luxury = 3
    }

    public static class EnumExtensionMethods
    {
        public static string GetDescription( this Enum GenericEnum )
        {
            Type genericEnumType = GenericEnum.GetType( );
            MemberInfo[] memberInfo = genericEnumType.GetMember( GenericEnum.ToString( ) );
            if ( ( memberInfo != null && memberInfo.Length > 0 ) )
            {
                var _Attribs = memberInfo[0].GetCustomAttributes( typeof( System.ComponentModel.DescriptionAttribute ), false );
                if ( ( _Attribs != null && _Attribs.Count( ) > 0 ) )
                {
                    return ( ( System.ComponentModel.DescriptionAttribute )_Attribs.ElementAt( 0 ) ).Description;
                }
            }
            return GenericEnum.ToString( );
        }
    }
}
