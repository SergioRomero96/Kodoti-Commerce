using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Service.Common.Mapping
{
    public static class DtoMapperExtension
    {
        //Serializa la clase en la que estamos trabajando y convertirla a una nueva clase, mientras las propiedades sean iguales
        public static T MapTo<T>(this object value)
        {
            return JsonSerializer.Deserialize<T>(
                JsonSerializer.Serialize(value)
            );
        }
    }
}
